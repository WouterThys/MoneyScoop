using DevExpress.Utils;
using DevExpress.Utils.Behaviors.Common;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MoneyScoop.Utils
{
    public static class ViewHelpers
    {
        public static void InitializeGridView(GridView gridView)
        {
            try
            {
                string noData = "No data";
                InitializeGridView(gridView, noData);
            }
            catch (Exception e)
            {
                Debug.WriteLine("InitializeGridView empty view setup failed: " + e);
            }
        }

        public static void InitializeGridView(GridView gridView, string noDataText)
        {
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsBehavior.AllowIncrementalSearch = true;
            gridView.OptionsSelection.MultiSelect = true;
            gridView.OptionsView.ShowDetailButtons = false;
            gridView.OptionsBehavior.AutoExpandAllGroups = true;

            if (!string.IsNullOrEmpty(noDataText))
            {
                gridView.CustomDrawEmptyForeground += (s, e) =>
                {
                    GridView gv = s as GridView;
                    if (gv.RowCount != 0) return;

                    StringFormat drawFormat = new StringFormat();
                    drawFormat.Alignment = drawFormat.LineAlignment = StringAlignment.Center;
                    e.Graphics.DrawString(
                        noDataText,
                        e.Appearance.Font,
                        SystemBrushes.ControlDark,
                        new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height),
                        drawFormat);
                };
            }
        }

        public static void InitializeLookUpEdit(LookUpEdit typeLookUp)
        {
            typeLookUp.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Near;
            typeLookUp.Properties.Columns.AddRange(new LookUpColumnInfo[] {
            new LookUpColumnInfo("Code", "Code"),
            new LookUpColumnInfo("Description", "Description")});
            typeLookUp.Properties.ValueMember = "Id";
            typeLookUp.Properties.DisplayMember = "Code";
            typeLookUp.Properties.NullText = "";
        }

        public static void InitializeSearchLookUpEdit(SearchLookUpEdit edit)
        {
            edit.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Near;
            edit.Properties.ValueMember = "Id";
            edit.Properties.DisplayMember = "Code";
            edit.Properties.NullText = "";
        }

        public static void InitializeTimeSpanTextEdit(TextEdit textEdit)
        {
            textEdit.Properties.Mask.EditMask = "HH:mm:ss";
            textEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            textEdit.Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
        }

        public static void SetTextAlignment(params BaseEdit[] values)
        {
            if (values != null)
            {
                foreach (BaseEdit edit in values)
                {
                    edit.Properties.Appearance.TextOptions.HAlignment
                        = HorzAlignment.Near;
                }
            }
        }

        public static void InitializeDaysTimeSpan(TimeSpanEdit edit)
        {
            edit.Properties.Mask.EditMask = "d:hh:mm:ss";
            edit.Properties.Mask.UseMaskAsDisplayFormat = true;
        }

        public static void InitializeLayoutPrecistance(PersistenceBehavior behaviour, string layoutXmlName, Action<string> _saveDefault = null)
        {
            //if (behaviour == null) return;
            //if (string.IsNullOrEmpty(layoutXmlName)) return;

            //if (!Directory.Exists("Layouts"))
            //{
            //    Directory.CreateDirectory("Layouts");
            //    DirectorySecurity sec = Directory.GetAccessControl("Layouts");
            //    SecurityIdentifier everyone = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
            //    sec.AddAccessRule(new FileSystemAccessRule(everyone, FileSystemRights.Modify | FileSystemRights.Synchronize, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            //    Directory.SetAccessControl("Layouts", sec);
            //}
            //try
            //{
            //    string path = Path.Combine("Layouts", layoutXmlName);
            //    if (_saveDefault != null)
            //    {
            //        string defaultPath = Path.Combine("Layouts", "Default");
            //        string defaultLayout = Path.Combine("Layouts", "Default", layoutXmlName);
            //        if (!Directory.Exists(defaultPath))
            //        {
            //            Directory.CreateDirectory(defaultPath);
            //        }
            //        if (!File.Exists(defaultLayout))
            //        {
            //            _saveDefault(defaultLayout);
            //        }
            //    }

            //    behaviour.Properties.Path = path;
            //}
            //catch (Exception e)
            //{
            //    Debug.WriteLine("Failed to InitializeLayoutPrecistance: " + e);
            //}
        }

        public static void RemoveLayoutPrecistance(string layoutXmlName, Action<string> _restoreLayout = null)
        {
            //if (string.IsNullOrEmpty(layoutXmlName)) return;
            //try
            //{
            //    File.Delete(Path.Combine("Layouts", layoutXmlName));
            //    if (_restoreLayout != null)
            //    {
            //        string defaultLayout = Path.Combine("Layouts", "Default", layoutXmlName);
            //        if (File.Exists(defaultLayout))
            //        {
            //            _restoreLayout(defaultLayout);
            //        }
            //    }
            //}
            //catch (Exception e)
            //{
            //    Debug.WriteLine("Failed to RemoveLayoutPrecistance: " + e);
            //}
        }

        public static void InitializeImageComboBox<T>(ImageComboBoxEdit edit)
        {
            if (edit == null) return;
            SetTextAlignment(edit);

            edit.Properties.Items.Clear();
            //edit.Properties.Items.AddEnum<T>((v) => ClientContext.Context.Translate(v));
        }

        public static void InitializeImageComboBox<T>(ImageComboBoxEdit edit, object images, int[] imageIndexes)
        {
            if (edit == null) return;
            SetTextAlignment(edit);

            edit.Properties.Items.Clear();
            edit.Properties.SmallImages = images;
            int index = 0;
            foreach (T t in Enum.GetValues(typeof(T)).Cast<T>())
            {
                edit.Properties.Items.Add(
                    t.ToString(),
                    t,
                    imageIndexes[index]);
                index++;
            }
        }

        public static void InitializeImageComboBox<T>(RepositoryItemImageComboBox edit)
        {
            if (edit == null) return;

            edit.Items.Clear();
            //edit.AddEnum<T>((v) => ClientContext.Context.Translate(v));
        }

        public static void InitializeImageComboBox<T>(RepositoryItemImageComboBox edit, object images, int[] imageIndexes)
        {
            if (edit == null) return;

            edit.Items.Clear();
            edit.SmallImages = images;
            int index = 0;
            foreach (T t in Enum.GetValues(typeof(T)).Cast<T>())
            {
                edit.Items.Add(
                    t.ToString(),
                    t,
                    imageIndexes[index]);
                index++;
            }
        }
    }
}
