using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FarmerPlusDataAccessLayer
{
    public class HelloWorldDBService
    {
        public HelloWorldDAO GetHelloWorldMessage(int id)
        {
            DBUtility db = new DBUtility();

            db.GetDataSetFromQuery("selct value from helloworld where id = " + id);            

            HelloWorldDAO _helloWorldDAO = new HelloWorldDAO();
            _helloWorldDAO.StrHelloWorldMessage = "Hello World from Farmer Plus";
            return _helloWorldDAO;
        }
    }
}
