using ShopDemo.Viewmodel.Helper;
using ShopDemo.Model;
namespace ShopDemo.Viewmodel;

public class Userview:BaseViewModel
{
    public  User UserList { get; set; }
    public  ButtonHelper  ClickHere { get; set; }
    public  ButtonHelper  ClearClick { get; set; }
  

    public Userview()
    {
        ClickHere = new ButtonHelper(GetData);
        ClearClick = new ButtonHelper(Clear);
        UserList = new();
        UserList.Name = "Vasanthasenan";
        UserList.Address = "Pattukottai";
        UserList.DOB = "04";
    }
    public void GetData()
    {
        string nam = UserList.Name;
        string address = UserList.Address;
        string dob = UserList.DOB;
    }
    public void Clear()
    {
      UserList.Name = "";
       UserList.Address = "";
       UserList.DOB = "";
    }
}
