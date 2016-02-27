using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Wallnut.Utils
{
    public static class Validation
    {
        #region FieldIsRequired
        public static void FieldIsRequired<T>(ref object sender, ref CancelEventArgs e
            , string nfield, ref ErrorProvider ep, ValType vt = ValType.Text) where T : Control
        {
            const string ERR_MSG = "Поле {0} не может быть пустым";
            switch (vt)
            {
                case ValType.Text:
                    #region Text
                    if (string.IsNullOrEmpty((sender as T).Text))
                    {
                        (sender as T).Parent.Focus();
                        e.Cancel = true; (sender as T).Focus(); ep.SetError((sender as T),
                        string.Format(ERR_MSG, nfield));
                    }
                    else
                    {
                        e.Cancel = false; ep.SetError((sender as T), "");
                    }
                    #endregion

                    break;
                case ValType.Date:
                    break;
                case ValType.Numeric:
                    if (Convert.ToDouble((sender as T).Text) == 0.0)
                    {
                        (sender as T).Parent.Focus();
                        e.Cancel = true; (sender as T).Focus(); ep.SetError((sender as T),
                        string.Format(ERR_MSG, nfield));
                    }
                    else
                    {
                        e.Cancel = false; ep.SetError((sender as T), "");
                    }
                    break;
                default:
                    break;
            }

        }
        #endregion

        public static void proc()
        {
            if (string.IsNullOrWhiteSpace("")) throw new ArgumentException("", "");
            decimal d = 0;
            if (decimal.TryParse("", out d)) throw new ArgumentException("", "");

            if (string.IsNullOrWhiteSpace("")) throw new ArgumentNullException("", "");
        }

        public static Tuple<bool, string> tfunc(string val)
        {
            Tuple<bool, string> result = Tuple.Create<bool, string>(true, "");
            if (string.IsNullOrWhiteSpace(val))
            {
                result = Tuple.Create<bool, string>(false, "Error!!!");
            }
            //result.Item1
            return result;
        }
        public static OperationResults ofunc(string val)
        {
            OperationResults result = new OperationResults();
            if (string.IsNullOrWhiteSpace(val))
            {
                result.Success = false;
                result.AddMessage( "Error!!!");
            }
            //result.Item1
            Debug.Assert(val!=null,"val==null");
            return result;
        }
        

    }

    public enum ValType
    {
        Text, Date, Numeric
    }


}
