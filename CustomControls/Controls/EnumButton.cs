using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devDept.Controls.WinForms
{
    public class EnumButton : System.Windows.Forms.Button
    {
        private Type _enumType;

        private IComparable _currentValue;

        public IComparable Value
        {
            get { return _currentValue; }
        }        

        public EnumButton()
        {
            Text = _currentValue != null ? _currentValue.ToString() : "EnumButton";
        }

        protected override void OnClick(EventArgs e)
        {
            var prev = _currentValue;

            foreach (IComparable en in Enum.GetValues(_enumType))
            {
                if (en.CompareTo(_currentValue) > 0)
                {
                    _currentValue = en;
                    Text = en.ToString();
                    break;
                }
            }

            if (_currentValue.CompareTo(prev) == 0)
            {
                System.Array values = (System.Array)Enum.GetValues(_enumType);
                _currentValue = (IComparable)values.GetValue(0);
                Text = _currentValue.ToString();
            }

            base.OnClick(e);
        }        

        public void Set(IComparable value)
        {
            _currentValue = value;
            _enumType = value.GetType();
            Text = value.ToString();
        }        
    }
}

namespace devDept.Controls.Wpf
{
    public class EnumButton : System.Windows.Controls.Button
    {
        private Type _enumType;

        private IComparable _currentValue;

        public IComparable Value
        {
            get { return _currentValue; }
        }        

        public EnumButton()
        {
            Content = _currentValue != null ? _currentValue.ToString() : "EnumButton";
        }

        protected override void OnClick()
        {
            var prev = _currentValue;

            foreach (IComparable en in Enum.GetValues(_enumType))
            {
                if (en.CompareTo(_currentValue) > 0)
                {
                    _currentValue = en;
                    Content = en.ToString();
                    break;
                }
            }

            if (_currentValue.CompareTo(prev) == 0)
            {
                System.Array values = (System.Array)Enum.GetValues(_enumType);
                _currentValue = (IComparable)values.GetValue(0);
                Content = _currentValue.ToString();
            }

            base.OnClick();
        }        

        public void Set(IComparable value)
        {
            _currentValue = value;
            _enumType = value.GetType();
            Content = value.ToString();
        }
    }
}
