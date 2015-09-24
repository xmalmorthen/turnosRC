using MetroFramework;
using MetroFramework.Forms;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using turnosAdministrator.Models;
using turnosAdministrator.Models.structures;
using System.Threading;
using turnosAdministrator.frms;

namespace turnosAdministrator
{
    public partial class frmMain : MetroForm
    {
        private DBDataContext db = new DBDataContext();

        private caWeathers dataToEdit = new caWeathers();
        private int position = 0;

        public enum frmWeatherStates
        {
            displayWeather,
            newWeather,
            saveNewWeather,
            editWeather,
            deleteWeather
        }
        private frmWeatherStates frmWState;
        public frmWeatherStates FrmWState
        {
            get { return frmWState; }
            set 
            {
                try
                {
                
                    txtWeather.Enabled = value == frmWeatherStates.editWeather || value == frmWeatherStates.newWeather;
                    txtWeatherDescrip.Enabled = value == frmWeatherStates.editWeather || value == frmWeatherStates.newWeather;
                    pnlBtns.Enabled = value == frmWeatherStates.editWeather || value == frmWeatherStates.newWeather;

                    pbNew.Visible = value == frmWeatherStates.displayWeather;
                    tableLayoutPanel3.Enabled = value == frmWeatherStates.displayWeather;

                    splitContainer1.Panel2Collapsed = value == frmWeatherStates.editWeather || value == frmWeatherStates.newWeather;
                
                    switch (value)
                    {
                        case frmWeatherStates.displayWeather:
                            refreshData();
                            caWeathersBindingSource.ResumeBinding();
                            break;
                        case frmWeatherStates.newWeather:
                            btnAcceptWeatherForm.Tag = "newWeather";
                            caWeathersBindingSource.SuspendBinding();
                            txtWeather.Focus();
                            break;
                        case frmWeatherStates.saveNewWeather:
                            if (btnAcceptWeatherForm.Tag.ToString() == "newWeather")
                            {
                                caWeathers itemToAdd = new caWeathers();
                                itemToAdd.weather = txtWeather.Text.Trim();
                                itemToAdd.description = txtWeatherDescrip.Text.Trim();
                                db.caWeathers.InsertOnSubmit(itemToAdd);
                            }
                            else
                            {
                                caWeathers itemToEdit = db.caWeathers.SingleOrDefault(qry => qry.id == dataToEdit.id);
                                itemToEdit.weather = txtWeather.Text.Trim();
                                itemToEdit.description = txtWeatherDescrip.Text.Trim();
                                itemToEdit.fact = DateTime.Now;
                            }

                            db.SubmitChanges();
                            refreshData();
                            caWeathersBindingSource.ResumeBinding();
                            if (btnAcceptWeatherForm.Tag.ToString() == "newWeather") caWeathersBindingSource.MoveLast(); else caWeathersBindingSource.Position = position;
                            break;
                        case frmWeatherStates.editWeather:
                            btnAcceptWeatherForm.Tag = "editWeather";

                            dataToEdit = (caWeathers)caWeathersBindingSource.Current;
                            position = caWeathersBindingSource.Position;
                            caWeathersBindingSource.SuspendBinding();

                            txtWeather.Text = dataToEdit.weather.ToString().Trim();
                            txtWeatherDescrip.Text = dataToEdit.description.ToString().Trim();

                            txtWeather.Focus();
                            txtWeather.SelectAll();
                            break;
                        case frmWeatherStates.deleteWeather:
                            db.caWeathers.DeleteOnSubmit(caWeathersBindingSource.Current as caWeathers);
                            db.SubmitChanges();
                            refreshData();                        
                            break;
                    }   
                
                    frmWState = value;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void refreshData() {            
            caWeathersBindingSource.DataSource = db.caWeathers.ToList();
        }

        public frmMain()
        {
            InitializeComponent();
            frmWState = frmWeatherStates.displayWeather;
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            metroContextMenu.Show(pictureBox2, new Point(0, pictureBox2.Height));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Confirma cerrar sistema", "Cerrar sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;           
            }
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Confirma cerrar sesión", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Retry;    
            }
        }

        private void pbNew_Click(object sender, EventArgs e)
        {            
            FrmWState = frmWeatherStates.newWeather;
        }

        private void btnAcceptWeatherForm_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtWeather.Text.Trim()))
                {
                    MetroMessageBox.Show(this, "Debe especificar un Municipio o Ciudad.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtWeather.Focus();
                }
                else {
                    if (FrmWState == frmWeatherStates.newWeather && db.caWeathers.SingleOrDefault(qry => qry.weather.Trim().ToLower() == txtWeather.Text.Trim().ToLower()) != null)
                    {
                        MetroMessageBox.Show(this, "Ya se encuentra un registro con el Municipio o Ciudad.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        FrmWState = frmWeatherStates.saveNewWeather;
                        MetroMessageBox.Show(this, "Registro guardado.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmWState = frmWeatherStates.displayWeather;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger logger = LogManager.GetCurrentClassLogger();
                logger.Error(ex, ex.Message);
                MetroMessageBox.Show(this, "Error al intentar guardar, favor de intentarlo de nuevo.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }           
        }

        private void btnCancelWeatherForm_Click(object sender, EventArgs e)
        {
            FrmWState = frmWeatherStates.displayWeather;
            caWeathersBindingSource.Position = position;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            strctVentanillaBindingSource.DataSource = mainModel.ventanillas();
            Thread actTurnos = new Thread(actualizarTurnos);
            actTurnos.Start();
            
            FrmWState = frmWeatherStates.displayWeather;
            FrmPLState = frmPlayListStates.displayPL;
        }

        private void pbDeleteWeatherForm_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroMessageBox.Show(this, "Confirma el borrado del registro", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    FrmWState = frmWeatherStates.deleteWeather;
                    MetroMessageBox.Show(this, "Registro borrado.", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmWState = frmWeatherStates.displayWeather;
                }
            }
            catch (Exception ex)
            {
                Logger logger = LogManager.GetCurrentClassLogger();
                logger.Error(ex, ex.Message);
                MetroMessageBox.Show(this, "Error al intentar borrar el registro, favor de intentarlo de nuevo.", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
        
        private void pbRefreshWeatherForm_Click(object sender, EventArgs e)
        {
            refreshData();
            MetroMessageBox.Show(this,"Registros actualizados", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void pbEditWeatherForm_Click(object sender, EventArgs e)
        {
            FrmWState = frmWeatherStates.editWeather;
        }

        private void pbActualizarTurnos_Click(object sender, EventArgs e)
        {
            Thread actTurnos = new Thread(actualizarTurnos);
            actTurnos.Start();
        }

        private void actualizarTurnos()
        {
            metroPanel1.Invoke((MethodInvoker)(() => metroPanel1.Enabled = false));
            pnlNotifications.Invoke((MethodInvoker)(() => pnlNotifications.Visible = true));
            try
            {
                short iter = 0;
                foreach (strctTurno item in mainModel.turnos())
                {
                    switch (iter)
                    {
                        case 0:
                            lblVentanillaActual.Invoke((MethodInvoker)(() => lblVentanillaActual.Text = item.NombreVentanilla));
                            lblTurnoActual.Invoke((MethodInvoker)(() => lblTurnoActual.Text = item.Turno.ToString()));
                            break;
                        case 1:
                            lblVentanilla1Atiende.Invoke((MethodInvoker)(() => lblVentanilla1Atiende.Text = item.NombreVentanilla));
                            lblTurno1Atiende.Invoke((MethodInvoker)(() => lblTurno1Atiende.Text = item.Turno.ToString()));
                            lblServicio1Atiende.Invoke((MethodInvoker)(() => lblServicio1Atiende.Text = item.Tramite));
                            break;
                        case 2:
                            lblVentanilla2Atiende.Invoke((MethodInvoker)(() => lblVentanilla2Atiende.Text = item.NombreVentanilla));
                            lblTurno2Atiende.Invoke((MethodInvoker)(() => lblTurno2Atiende.Text = item.Turno.ToString()));
                            lblServicio2Atiende.Invoke((MethodInvoker)(() => lblServicio2Atiende.Text = item.Tramite));
                            break;
                    }
                    iter++;
                }
            }
            catch (Exception)
            {
                lblVentanillaActual.Invoke((MethodInvoker)(() => lblVentanillaActual.Text = "No se encuntraron citas para hoy"));
            }
            pnlNotifications.Invoke((MethodInvoker)(() => pnlNotifications.Visible = false));
            metroPanel1.Invoke((MethodInvoker)(() => metroPanel1.Enabled = true));
        }

        private void btnTurnoSiguiente_Click(object sender, EventArgs e)
        {
            Thread sigTurno = new Thread(siguienteTurno);
            sigTurno.Start();            
        }

        private void siguienteTurno() {
            metroPanel1.Invoke((MethodInvoker)(() => metroPanel1.Enabled = false));
            pnlNotifications.Invoke((MethodInvoker)(() => pnlNotifications.Visible = true));
           
            mainModel.siguienteTurno(((strctVentanilla)strctVentanillaBindingSource.Current).ID_Ventanilla);
            pbActualizarTurnos_Click(null, null);

            pnlNotifications.Invoke((MethodInvoker)(() => pnlNotifications.Visible = false));
            metroPanel1.Invoke((MethodInvoker)(() => metroPanel1.Enabled = true));
        }

        private void refreshPlayList()
        {
            caPlayListBingSource.DataSource = db.caPlayList.ToList();
        }

        private List<dePlayList> playListVideos;
        private int pLPosition = 0;
        private caPlayList plDataToEdit = new caPlayList();

        public enum frmPlayListStates
        {
            displayPL,
            newPL,
            savePL,
            editPL,
            deletePL
        }
        private frmPlayListStates frmPLState;
        public frmPlayListStates FrmPLState
        {
            get { return frmPLState; }
            set
            {
                try
                {

                    switch (value)
                    {
                        case frmPlayListStates.displayPL:
                            refreshPlayList();
                            caPlayListBingSource.ResumeBinding();
                            dePlayListBindingSource.ResumeBinding();
                            break;
                        case frmPlayListStates.newPL:
                            caPlayListBingSource.SuspendBinding();

                            playListVideos = new List<dePlayList>();
                            dePlayListBindingSource.DataSource = playListVideos;

                            txtPlayListname.Focus();
                            txtPlayListname.SelectAll();
                            break;
                        case frmPlayListStates.savePL:
                            if (FrmPLState == frmPlayListStates.newPL)
                            {
                                caPlayList itemToAdd = new caPlayList();
                                itemToAdd.playListName = txtPlayListname.Text.Trim();
                                itemToAdd.totalVideos = Convert.ToInt16(dePlayListBindingSource.Count);

                                itemToAdd.dePlayList.AddRange(playListVideos);

                                db.caPlayList.InsertOnSubmit(itemToAdd);
                            }
                            else
                            {
                                caPlayList itemToEdit = (from qry in db.caPlayList where qry.id == plDataToEdit.id select qry).SingleOrDefault();
                                itemToEdit.playListName = txtPlayListname.Text.Trim();
                                itemToEdit.fAct = DateTime.Now;
                                itemToEdit.totalVideos = Convert.ToInt16(dePlayListBindingSource.Count);

                                db.dePlayList.DeleteAllOnSubmit((from qry in db.dePlayList where qry.idPlayList == plDataToEdit.id select qry));

                                List<dePlayList> _playListVideos = new List<dePlayList>();

                                foreach (dePlayList item in playListVideos)
                                {
                                    dePlayList val = new dePlayList();
                                    val.videoPath = item.videoPath;
                                    val.fAct = DateTime.Now;
                                    _playListVideos.Add(val);
                                }
                                itemToEdit.dePlayList.AddRange(_playListVideos);
                            }

                            db.SubmitChanges();
                            refreshPlayList();

                            caPlayListBingSource.ResumeBinding();
                            dePlayListBindingSource.ResumeBinding();

                            if (FrmPLState == frmPlayListStates.newPL) caPlayListBingSource.MoveLast(); else caPlayListBingSource.Position = pLPosition;
                            break;
                        case frmPlayListStates.editPL:

                            plDataToEdit = (caPlayList)caPlayListBingSource.Current;
                            pLPosition = caPlayListBingSource.Position;

                            playListVideos = (from qry in db.dePlayList where qry.idPlayList == plDataToEdit.id select qry).ToList();
                            dePlayListBindingSource.DataSource = playListVideos;

                            caPlayListBingSource.SuspendBinding();

                            txtPlayListname.Text = plDataToEdit.playListName;

                            gdVideos.Focus();

                            break;
                        case frmPlayListStates.deletePL:
                            playListVideos = (from qry in db.dePlayList where qry.idPlayList == ((caPlayList)caPlayListBingSource.Current).id select qry).ToList();
                            db.dePlayList.DeleteAllOnSubmit(playListVideos);
                            db.caPlayList.DeleteOnSubmit(caPlayListBingSource.Current as caPlayList);

                            db.SubmitChanges();
                            refreshPlayList();
                            break;
                    }


                    pbNewPlayList.Visible = value == frmPlayListStates.displayPL;
                    pbSavePlayList.Visible = value == frmPlayListStates.editPL || value == frmPlayListStates.newPL; ;
                    pbCancelPlayList.Visible = value == frmPlayListStates.editPL || value == frmPlayListStates.newPL;

                    txtPlayListname.Enabled = value == frmPlayListStates.newPL || value == frmPlayListStates.editPL;
                    pbNewVideo.Visible = value == frmPlayListStates.editPL || value == frmPlayListStates.newPL;
                    pbDeleteVideo.Visible = value == frmPlayListStates.editPL || value == frmPlayListStates.newPL && dePlayListBindingSource.Count > 0;


                    pnlPlayList.Enabled = value == frmPlayListStates.displayPL;

                    splitContainer2.Panel2Collapsed = value == frmPlayListStates.editPL || value == frmPlayListStates.newPL;
                    
                    frmPLState = value;

                    dePlayListBindingSource_ListChanged(null, null);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void pbNewPlayList_Click(object sender, EventArgs e)
        {
            FrmPLState = frmPlayListStates.newPL;
        }

        
        private void pbSavePlayList_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPlayListname.Text.Trim()))
                {
                    MetroMessageBox.Show(this, "Debe especificar el nombre de la lista de reproducción.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPlayListname.Focus();
                }
                else if (dePlayListBindingSource.Count == 0) {
                    MetroMessageBox.Show(this, "Debe agregar videos a la lista de reproducción.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (FrmPLState == frmPlayListStates.newPL && db.caPlayList.SingleOrDefault(qry => qry.playListName.Trim().ToLower() == txtPlayListname.Text.Trim().ToLower()) != null)
                    {
                        MetroMessageBox.Show(this, string.Format("Ya se encuentra un registro con el nombre [ {0} ]", txtPlayListname.Text.Trim()), "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPlayListname.Focus();
                        txtPlayListname.SelectAll();
                    }
                    else
                    {
                        FrmPLState = frmPlayListStates.savePL;
                        MetroMessageBox.Show(this, "Registro guardado.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmPLState = frmPlayListStates.displayPL;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger logger = LogManager.GetCurrentClassLogger();
                logger.Error(ex, ex.Message);
                MetroMessageBox.Show(this, "Error al intentar guardar, favor de intentarlo de nuevo.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (FrmPLState == frmPlayListStates.editPL) {
                    txtPlayListname.Text = plDataToEdit.playListName.Trim();
                }                
            }    
        }

        private void pbCancelPlayList_Click(object sender, EventArgs e)
        {
            FrmPLState = frmPlayListStates.displayPL;
        }

        private void pbDeletePlayList_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Confirma la eliminación del video de la lista de reproducción", "Quitar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                FrmPLState = frmPlayListStates.deletePL;
                MetroMessageBox.Show(this, "Lista de reproducción eliminada.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmPLState = frmPlayListStates.displayPL;
            }
        }

        private void pbRefreshPlayList_Click(object sender, EventArgs e)
        {
            refreshPlayList();
        }

        private void pbEditPlayList_Click(object sender, EventArgs e)
        {
            FrmPLState = frmPlayListStates.editPL;
        }

        private void pbNewVideo_Click(object sender, EventArgs e)
        {
            openFileDialog.DefaultExt = ".mpg";
            openFileDialog.Filter = "Media Files|*.mpg;*.mp4;*.avi;*.wma;*.mov;*.wav;*.mp2;*.mp3|All Files|*.*";
            openFileDialog.Title = "Incluir video a lista de reproducción";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {

                foreach (String file in openFileDialog.FileNames)
                {
                    dePlayList item = new dePlayList();
                    item.videoPath = file;
                    item.fIns = DateTime.Now;

                    dePlayListBindingSource.Add(item);
                }
                gdVideos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            }
        }

        private void pbDeleteVideo_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Confirma la eliminación del video de la lista de reproducción", "Quitar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (DataGridViewCell oneCell in gdVideos.SelectedCells)
                {
                    if (oneCell.Selected)
                        gdVideos.Rows.RemoveAt(oneCell.RowIndex);
                }
            }
        }
                
        private void dePlayListBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (FrmPLState != frmPlayListStates.displayPL)
            {                
                pbDeleteVideo.Visible = dePlayListBindingSource.Count > 0;
            }
            pbPlayVideo.Visible = dePlayListBindingSource.Count > 0;
        }

        private void caPlayListBingSource_PositionChanged(object sender, EventArgs e)
        {
            try 
	        {	        
		        dePlayListBindingSource.DataSource = (from qry in db.dePlayList where qry.idPlayList == ((caPlayList)caPlayListBingSource.Current).id select qry).ToList();
                gdVideos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

                pbDefault.Visible = ((caPlayList)caPlayListBingSource.Current).defaultPL == false;
	        }
	        catch (Exception){}                
        }

        private void caPlayListBingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (FrmPLState == frmPlayListStates.displayPL)
            {
                pbEditPlayList.Visible = caPlayListBingSource.Count > 0;
                pbDeletePlayList.Visible = caPlayListBingSource.Count > 0;
            }
            gdPlayList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private void pbPlayVideo_Click(object sender, EventArgs e)
        {
            frmVideoPlayer frmVP = new frmVideoPlayer();
            frmVP.wmp.URL = ((dePlayList)dePlayListBindingSource.Current).videoPath.ToString().Trim();
            frmVP.ShowDialog(this);
            frmVP.wmp.close();
            frmVP.Close();
            frmVP.Dispose();
        }

        private void pbDefault_Click(object sender, EventArgs e)
        {
            try
            {
                caPlayList noDefault = db.caPlayList.SingleOrDefault(qry => qry.defaultPL == true);
                noDefault.defaultPL = false;

                caPlayList item = (caPlayList)caPlayListBingSource.Current;
                item.defaultPL = true;
                db.SubmitChanges();
                pbDefault.Visible = false;

                MetroMessageBox.Show(this, "Lista de reproducción establecida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Ocurrió un error al intentar establecer la lista de reproducción, favor de intentarlo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
