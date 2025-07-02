namespace ReqnrollProject.Utils
{
    public static class TestData
    {
        public static class Users
        {
            public static string StandardUser => "standard_user";
            public static string StandardPassword => "secret_sauce";
            public static string LockedOutUser => "locked_out_user";
            public static string LockedPassword => "secret_sauce";
            public static string URL => "https://www.saucedemo.com/";

        }

        public static class CheckoutDetails
        {
            public static string FirstName => "Jerome";
            public static string LastName => "Test";
            public static string PostalCode => "P2";
        }
    }
}
