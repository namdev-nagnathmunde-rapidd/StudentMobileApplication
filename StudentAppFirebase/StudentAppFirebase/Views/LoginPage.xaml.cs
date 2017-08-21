using Firebase.Xamarin.Auth;
using StudentAppFirebase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentAppFirebase.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
           // await Navigation.PushAsync(new SignUpPage());
        }

              
        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var user = new LoginUser
            {
                UserEmail = UserEmailEntry.Text,
                Password = passwordEntry.Text
            };

            //Calling Auth

            // Email/Password Auth
            var authProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyDhxe5x5aiiHdxlDC0XtIncM-Ja1upWrXY"));

            var auth = await authProvider.CreateUserWithEmailAndPasswordAsync(user.UserEmail, user.Password);

            // The auth Object will contain auth.User and the Authentication Token from the request
           System.Diagnostics.Debug.WriteLine(auth.FirebaseToken);


            var auth = await authProvider.SignInWithOAuthAsync(FirebaseAuthType.Facebook, facebookAccessToken);

            var isValid = AreCredentialsCorrect(user);
            if (isValid)
            {
                App.IsUserLoggedIn = true;
               // MainPage = App.ManuPage;
               // Navigation.InsertPageBefore(new ManuPage(), this);
                await Navigation.PopAsync();
            }
            else
            {
                messageLabel.Text = "Login failed";
                passwordEntry.Text = string.Empty;
            }
        }

        bool AreCredentialsCorrect(LoginUser user)
        {
            return user.UserEmail.Contains("@") && user.Password !=null;
            
        }
    }


}
