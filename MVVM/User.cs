namespace ShopDemo.Model
{
    public class User:BaseViewModel
    {
        private String _name;
        public String Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        private String _Address;

        public String Address
        {
            get { return _Address; }
            set { _Address = value; OnPropertyChanged(); }
        }

        private string _dob;

        public string DOB
        {
            get { return _dob; }
            set { _dob = value; OnPropertyChanged(); }
        }

    }
}
