HomePage homePage = new HomePage
{
  MenuItems = new [] {"Home" , "About Us"},
  Height = 220,
  Width= 550,
  ProfileAvatar = new byte[] { 105,215,218,220}
};


AboutUsPage aboutUsPage = new AboutUsPage
{
  MenuItems = new[] { "Home", "About Us" },
  Height = 220,
  Width = 550,
  ProfileAvatar = new byte[] { 105,215,218,220 },
  Contacts = new[] { 984123456, 984123478, 984123489 }
};

homePage.Login("Ram","Ram@12345");
homePage.Navigate("https://www.test.com/HomePage");
homePage.GetCurrentUrl();
homePage.HandleMenuClick("Home");
aboutUsPage.Navigate("https://www.test.com/AboutUs");
homePage.HandleMenuClick("About Us");
aboutUsPage.GetCurrentUrl();
aboutUsPage.InitiatePhone("984123456");
aboutUsPage.InitiateEmail("ram.nepal@gmail.com");