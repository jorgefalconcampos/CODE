using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Neurotec.Gui
{
	public partial class CargaForm : Form
	{

        private DoWorkEventHandler callback;
		private object argument;
		private RunWorkerCompletedEventArgs results;
		private Exception error;
		protected BackgroundWorker _worker = new BackgroundWorker();

		private CargaForm(string title, DoWorkEventHandler callback): this(title, callback, false, null, null)
		{ }

		private CargaForm(string title, DoWorkEventHandler callback, object args): this(title, callback, false, args, null)
		{ }

        private CargaForm(string title, DoWorkEventHandler callback, bool reportsProgress) : this(title, callback, reportsProgress, null, null)
        { }

        private void btnCancel_Click(object sender, EventArgs e)
        { }

        private CargaForm(string title, DoWorkEventHandler callback, bool reportsProgress, object args, EventHandler cancelHandler)
		{
			InitializeComponent();

			if (!reportsProgress)
				progressBar.Style = ProgressBarStyle.Marquee;

			SetExecutionText(title);
			this.callback = callback;
			argument = args;
			_worker.WorkerReportsProgress = reportsProgress;
			_worker.DoWork += BusyForm_DoWork;
			_worker.RunWorkerCompleted += BusyForm_RunWorkerCompleted;
			_worker.ProgressChanged += BusyForm_ProgressChanged;

			if (cancelHandler != null)
			{
				_worker.WorkerSupportsCancellation = true;
				btnCancel.Click += cancelHandler;
				btnCancel.Click += new EventHandler(PostOnCancelClick);
				btnCancel.Enabled = true;
				btnCancel.Visible = true;
			}
		}

		void PostOnCancelClick(object sender, EventArgs e)
		{
			btnCancel.Enabled = false;
			btnCancel.Refresh();
		}

		public static RunWorkerCompletedEventArgs RunLongTask_1(string title, DoWorkEventHandler callback)
		{ return RunLongTask_2(title, callback, false); }

		public static RunWorkerCompletedEventArgs RunLongTask_2(string title, DoWorkEventHandler callback, bool reportsProgress)
		{
			using (CargaForm FormCarga = new CargaForm(title, callback, reportsProgress))
			{
                FormCarga.ShowDialog();
				if (FormCarga.error != null)
				{ throw FormCarga.error; }
                return FormCarga.results;
			}
		}

		public static RunWorkerCompletedEventArgs RunLongTask_3(string title, DoWorkEventHandler callback, bool reportsProgress, object args, EventHandler cancelHandler)
		{
			using (CargaForm FormCarga = new CargaForm(title, callback, reportsProgress, args, cancelHandler))
			{
                FormCarga.ShowDialog();
				if (FormCarga.error != null)
				{ throw FormCarga.error; }             
                return FormCarga.results;
			}
		}

		private void BusyForm_Shown(object sender, EventArgs e)
		{ _worker.RunWorkerAsync(argument); }

		#region Background worker
		private void BusyForm_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				if (callback != null) { callback(sender, e); }
			}
			catch (Exception ex) { error = ex; }
		}

		private void BusyForm_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			string text = e.UserState as string;
			if (text != null) { SetExecutionText(text); }

			SetExecutionValue(e.ProgressPercentage);
		}

		private void BusyForm_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{ results = e; Close(); }
		#endregion

		#region Setters/Getters
		public void SetExecutionText(string texto)
		{
			try
			{
				if (lblOperation.InvokeRequired)
				{
					lblOperation.Invoke((MethodInvoker)delegate()
					{ lblOperation.Text = texto; });
				}
				else
				{ lblOperation.Text = texto; }
			}
			finally { }
		}

		public void SetExecutionValue(int valor)
		{
			try
			{
				if (progressBar.InvokeRequired)
				{
					progressBar.Invoke((MethodInvoker)delegate()
					{
						progressBar.Value = valor;
					});
				}
				else
				{ progressBar.Value = valor; }
			}
			finally { }
		}
        #endregion
    }
}
