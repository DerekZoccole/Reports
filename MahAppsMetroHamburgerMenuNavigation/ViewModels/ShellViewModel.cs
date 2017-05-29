using System;
using MahApps.Metro.IconPacks;

namespace MahAppsMetroHamburgerMenuNavigation.ViewModels
{
    internal class ShellViewModel : ViewModelBase
    {
        MenuItem _clientMenuItem = new MenuItem() { Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.Users } , Text = "Clients", NavigationDestination = new Uri("Views/BrowseClients.xaml", UriKind.RelativeOrAbsolute)};
        MenuItem _workDescriptionMenuItem = new MenuItem() { Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.Briefcase }, Text = "Work Description", NavigationDestination = new Uri("Views/WorkDescription.xaml", UriKind.RelativeOrAbsolute) };
        MenuItem _estimateMenuItem = new MenuItem() { Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.Book }, Text = "Estimate Report", NavigationDestination = new Uri("Views/Reports.xaml", UriKind.RelativeOrAbsolute) };
        MenuItem _invitationToBidMenuItem = new MenuItem() { Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.AddressBook }, Text = "Invitation To Bid Report", NavigationDestination = new Uri("Views/InvitationToBid.xaml", UriKind.RelativeOrAbsolute) };

        MenuItem _toolsMenuItem = new MenuItem() { Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.Wrench }, Text = "Tools", NavigationDestination = new Uri("Views/Tools.xaml", UriKind.RelativeOrAbsolute) };
        MenuItem _saveMenuItem = new MenuItem() { Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.FloppyOutline }, Text = "Save All", NavigationDestination = new Uri("Views/Save.xaml", UriKind.RelativeOrAbsolute) };

        public ShellViewModel()
        {
            // Build the menus
            this.Menu.Add(_clientMenuItem);
            this.Menu.Add(_workDescriptionMenuItem);
            this.Menu.Add(_estimateMenuItem);
            this.Menu.Add(_invitationToBidMenuItem);
            //this.Menu.Add(new MenuItem() {Icon = new PackIconFontAwesome() {Kind = PackIconFontAwesomeKind.Bug}, Text = "Bugs", NavigationDestination = new Uri("Views/BugsPage.xaml", UriKind.RelativeOrAbsolute)});
            //this.Menu.Add(new MenuItem() {Icon = new PackIconFontAwesome() {Kind = PackIconFontAwesomeKind.UserOutline}, Text = "User", NavigationDestination = new Uri("Views/UserPage.xaml", UriKind.RelativeOrAbsolute)});
            //this.Menu.Add(new MenuItem() {Icon = new PackIconFontAwesome() {Kind = PackIconFontAwesomeKind.Coffee}, Text = "Break", NavigationDestination = new Uri("Views/BreakPage.xaml", UriKind.RelativeOrAbsolute)});
            //this.Menu.Add(new MenuItem() {Icon = new PackIconFontAwesome() {Kind = PackIconFontAwesomeKind.FontAwesome}, Text = "Awesome", NavigationDestination = new Uri("Views/AwesomePage.xaml", UriKind.RelativeOrAbsolute)});

            this.OptionsMenu.Add(_toolsMenuItem);
            this.OptionsMenu.Add(_saveMenuItem);
            //this.OptionsMenu.Add(new MenuItem() {Icon = new PackIconFontAwesome() {Kind = PackIconFontAwesomeKind.Cogs}, Text = "Settings", NavigationDestination = new Uri("Views/SettingsPage.xaml", UriKind.RelativeOrAbsolute)});
            //this.OptionsMenu.Add(new MenuItem() {Icon = new PackIconFontAwesome() {Kind = PackIconFontAwesomeKind.InfoCircle}, Text = "About", NavigationDestination = new Uri("Views/AboutPage.xaml", UriKind.RelativeOrAbsolute)});
        }
    }
}