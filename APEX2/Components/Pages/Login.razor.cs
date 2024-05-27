using TelerikBlazorDemos.Models.Form;

namespace APEX2.Components.Pages
{
    public partial class  Login
    {
        private User TestUser = new User();

        public bool HidePassword { get; set; } = true;
        public string Icon { get; set; } = "k-icon k-svg-icon k-svg-i-eye-slash";


        public async Task RevealPassword()
        {
            HidePassword = false;
            await Task.Delay(1700);
            HidePassword = true;


        }

        private void HandleValidSubmit()
        {
            // Handle valid form submission
        }

    }
}
