using System;
using System.Collections.Generic;

using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using mpls_renters_desktop.Models;
using Newtonsoft.Json;

namespace mpls_renters_desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        bool sortedApartments;
        string searchPlaceHolder = "Search by Apartment Name";
        List<Apartment> globalApartmentList = GetProperties();
        public MainWindow()
        {
            
            InitializeComponent();
            //GetProperties();
            propGrid.ItemsSource = globalApartmentList;
        }


        static List<Apartment> GetProperties()
        {
           

            string filePath = Directory.GetCurrentDirectory();
            string stepBackOne = Directory.GetParent(filePath).ToString();
            string stepBackTwo = Directory.GetParent(stepBackOne).ToString();
            string stepBackThree = Directory.GetParent(stepBackTwo).ToString();
            string adjustedFilePath = @"apartments.json";//$@"{stepBackThree}\apartment_list.csv";
            string json = @"[
    {
      'property_id': 1,
      'apartment_name': '360 Nicollet',
      'floor_count': 30,
      'website': 'https://www.365nicollet.com',
      'short_description': '365 Nicollet is a 30-story residential tower offering luxurious living in downtown Minneapolis. Choose from stunning Tower or Penthouse Collection suites ranging from studios to three bedrooms.',
      'long_description': '',
      'latitude': 44.980087,
      'longitude':  -93.269534,
      'contact_email': 'Living@365Nicollet.com',
      'phone': '612-767-6365',
      'address': '365 Nicollett Mall',
      'city': 'Minneapolis',
      'zip': 55401,
      'city_region': 'West',
      'facebook_url': 'https://www.facebook.com/365Nicollet/',
      'instagram_url': 'https://www.instagram.com/365nicollet/',
      'tour_schedule_url': 'https://www.365nicollet.com/scheduletour.aspx',
      'skyway_connected': true
    },
    {
      'property_id': 2,
      'apartment_name': 'The Nic on Fifth',
      'floor_count': 26,
      'website': 'https://www.theniconfifth.com/',
      'short_description': 'At The Nic on Fifth, we want you to have an incredible experience while living in Minneapolis. Here you will enjoy world class luxury amenities. We take pride in our pool deck, which provides a relaxing experience in an urban setting. Cats and dogs of all sizes are welcome. Choose from studio, one, and two bedroom apartments, and an array of penthouses.',
      'long_description': '',
      'latitude': 44.9759423,
      'longitude': -93.2754785,
      'contact_email': '',
      'phone': '844-680-7750',
      'address': '465 Nicollet Mall',
      'city': 'Minneapolis',
      'zip': 55401,
      'city_region': 'West',
      'facebook_url': '',
      'instagram_url': '',
      'tour_schedule_url': 'https://www.theniconfifth.com/scheduletour.aspx',
      'skyway_connected': true
    },
    {
      'property_id': 3,
      'apartment_name': 'Nord Haus',
      'floor_count': 19,
      'website': 'https://livenordhaus.com/',
      'short_description': 'NordHaus is a collection of custom designed apartment homes located in the heart of Northeast Minneapolis. Surrounded by art galleries, craft breweries, youre just a 5 minute walk from SE Main Street.',
      'long_description': '',
      'latitude': 44.989783,
      'longitude': -93.256715,
      'contact_email': '',
      'phone': '612-567-5856',
      'address': '315 First Ave NE',
      'city': 'Minneapolis',
      'zip': 55413,
      'city_region': 'North',
      'facebook_url': 'https://www.facebook.com/NordHaus-Apartments-193623434472470/?business_id=10152351843569482',
      'instagram_url': 'https://www.instagram.com/nordhausapt/',
      'tour_schedule_url': '',
      'skyway_connected': false
    },
    {
      'property_id': 4,
      'apartment_name': 'Latitude 45',
      'floor_count': 13,
      'website': 'https://l45living.com/',
      'short_description': 'Luxury apartments in Minneapolis, MN. Latitude 45  sophisticated apartments for rent in Minneapolis sits at the intersection of outdoor recreation, social gatherings and posh dining.',
      'long_description': '',
      'latitude': 44.9775444,
      'longitude': -93.2764996,
      'contact_email': '',
      'phone': '612-999-2719',
      'address': '313 Washington Avenue South',
      'city': 'Minneapolis',
      'zip': 55415,
      'city_region': 'West',
      'facebook_url': 'https://www.facebook.com/l45living/',
      'instagram_url': 'https://www.instagram.com/latitude45apartments/?hl=en',
      'tour_schedule_url': 'https://l45living.com/schedule-a-tour/',
      'skyway_connected': true
    },
    {
      'property_id': 5,
      'apartment_name': 'Mpls Encore',
      'floor_count': 11,
      'website': 'https://mplsencore.com/',
      'short_description': 'Encore lends a coveted slice of urban riverbank and the prestigious nuance of the artistic liveliness that lies in the shadow of The Guthrie Theatre. Situated in the heart of the Mill District across from Gold Medal Park, the 12-storied Encore offers multilevel townhomes with private access and expansive penthouse homes overlooking the Mississippi River and downtown skyline.',
      'long_description': '',
      'latitude': 44.9766661,
      'longitude': -93.2564574,
      'contact_email': 'info@mplsencore.com',
      'phone': '612-223-7781',
      'address': '212 10th Avenue South',
      'city': 'Minneapolis',
      'zip': 55415,
      'city_region': 'East',
      'facebook_url': '',
      'instagram_url': '',
      'tour_schedule_url': '',
      'skyway_connected': false
    },
    {
        'property_id': 6,
        'apartment_name': 'HQ Apartments',
        'floor_count': 17,
        'website': 'http://www.hqminneapolis.com',
        'short_description': 'Rising from the burgeoning Elliot Park neighborhood, HQ is adjacent to the Finnegans Brewery and steps from downtown. ',
        'long_description': '',
        'latitude': 44.972113,
        'longitude': -93.265417,
        'contact_email': '',
        'phone': '(844) 836-6688',
        'address': '816 Portland Ave.',
        'city': 'Minneapolis',
        'zip': 55404,
        'city_region': 'East',
        'facebook_url': 'https://www.facebook.com/hqapartments/',
        'instagram_url': '',
        'tour_schedule_url': 'http://www.hqminneapolis.com/contact/',
        'skyway_connected': false
    },
    {
      'property_id': 7,
      'apartment_name': '4 Marq',
      'floor_count': 30,
      'website': 'https://www.4marqapartments.com',
      'short_description': '4Marq is an alluring community of luxury Minneapolis apartments offering top-tier amenities, extravagant homes, and premier resident services all in an extremely desirable location. Each of our spacious one-, two-, and three-bedroom floor plans offer unique features such as floor-to-ceiling windows with spectacular views, 9-foot exposed concrete ceilings and duct-work, plank flooring, granite countertops, designer cabinetry and fixtures, and stainless steel appliances.',
      'long_description': '',
      'latitude': 44.979310,
      'longitude':  -93.268934,
      'contact_email': '',
      'phone': '612-424-8127',
      'address': '400 Marquette Avenue South',
      'city': 'Minneapolis',
      'zip': 55401,
      'city_region': 'East',
      'facebook_url': 'https://www.facebook.com/4Marq',
      'instagram_url': 'https://www.instagram.com/4marqapartments/',
      'tour_schedule_url': '',
      'skyway_connected': false
    },
    {
      'property_id': 1,
      'apartment_name': '360 Nicollet',
      'floor_count': 30,
      'website': 'https://www.365nicollet.com',
      'short_description': '365 Nicollet is a 30-story residential tower offering luxurious living in downtown Minneapolis. Choose from stunning Tower or Penthouse Collection suites ranging from studios to three bedrooms.',
      'long_description': '',
      'latitude': 44.980087,
      'longitude':  -93.269534,
      'contact_email': 'Living@365Nicollet.com',
      'phone': '612-767-6365',
      'address': '365 Nicollett Mall',
      'city': 'Minneapolis',
      'zip': 55401,
      'city_region': 'West',
      'facebook_url': 'https://www.facebook.com/365Nicollet/',
      'instagram_url': 'https://www.instagram.com/365nicollet/',
      'tour_schedule_url': 'https://www.365nicollet.com/scheduletour.aspx',
      'skyway_connected': true
    },
    {
      'property_id': 2,
      'apartment_name': 'The Nic on Fifth',
      'floor_count': 26,
      'website': 'https://www.theniconfifth.com/',
      'short_description': 'At The Nic on Fifth, we want you to have an incredible experience while living in Minneapolis. Here you will enjoy world class luxury amenities. We take pride in our pool deck, which provides a relaxing experience in an urban setting. Cats and dogs of all sizes are welcome. Choose from studio, one, and two bedroom apartments, and an array of penthouses.',
      'long_description': '',
      'latitude': 44.9759423,
      'longitude': -93.2754785,
      'contact_email': '',
      'phone': '844-680-7750',
      'address': '465 Nicollet Mall',
      'city': 'Minneapolis',
      'zip': 55401,
      'city_region': 'West',
      'facebook_url': '',
      'instagram_url': '',
      'tour_schedule_url': 'https://www.theniconfifth.com/scheduletour.aspx',
      'skyway_connected': true
    },
    {
      'property_id': 3,
      'apartment_name': 'Nord Haus',
      'floor_count': 19,
      'website': 'https://livenordhaus.com/',
      'short_description': 'NordHaus is a collection of custom designed apartment homes located in the heart of Northeast Minneapolis. Surrounded by art galleries, craft breweries, youre just a 5 minute walk from SE Main Street.',
      'long_description': '',
      'latitude': 44.989783,
      'longitude': -93.256715,
      'contact_email': '',
      'phone': '612-567-5856',
      'address': '315 First Ave NE',
      'city': 'Minneapolis',
      'zip': 55413,
      'city_region': 'North',
      'facebook_url': 'https://www.facebook.com/NordHaus-Apartments-193623434472470/?business_id=10152351843569482',
      'instagram_url': 'https://www.instagram.com/nordhausapt/',
      'tour_schedule_url': '',
      'skyway_connected': false
    },
    {
      'property_id': 4,
      'apartment_name': 'Latitude 45',
      'floor_count': 13,
      'website': 'https://l45living.com/',
      'short_description': 'Luxury apartments in Minneapolis, MN. Latitude 45  sophisticated apartments for rent in Minneapolis sits at the intersection of outdoor recreation, social gatherings and posh dining.',
      'long_description': '',
      'latitude': 44.9775444,
      'longitude': -93.2764996,
      'contact_email': '',
      'phone': '612-999-2719',
      'address': '313 Washington Avenue South',
      'city': 'Minneapolis',
      'zip': 55415,
      'city_region': 'West',
      'facebook_url': 'https://www.facebook.com/l45living/',
      'instagram_url': 'https://www.instagram.com/latitude45apartments/?hl=en',
      'tour_schedule_url': 'https://l45living.com/schedule-a-tour/',
      'skyway_connected': true
    },
    {
      'property_id': 5,
      'apartment_name': 'Mpls Encore',
      'floor_count': 11,
      'website': 'https://mplsencore.com/',
      'short_description': 'Encore lends a coveted slice of urban riverbank and the prestigious nuance of the artistic liveliness that lies in the shadow of The Guthrie Theatre. Situated in the heart of the Mill District across from Gold Medal Park, the 12-storied Encore offers multilevel townhomes with private access and expansive penthouse homes overlooking the Mississippi River and downtown skyline.',
      'long_description': '',
      'latitude': 44.9766661,
      'longitude': -93.2564574,
      'contact_email': 'info@mplsencore.com',
      'phone': '612-223-7781',
      'address': '212 10th Avenue South',
      'city': 'Minneapolis',
      'zip': 55415,
      'city_region': 'East',
      'facebook_url': '',
      'instagram_url': '',
      'tour_schedule_url': '',
      'skyway_connected': false
    },
    {
        'property_id': 6,
        'apartment_name': 'HQ Apartments',
        'floor_count': 17,
        'website': 'http://www.hqminneapolis.com',
        'short_description': 'Rising from the burgeoning Elliot Park neighborhood, HQ is adjacent to the Finnegans Brewery and steps from downtown. ',
        'long_description': '',
        'latitude': 44.972113,
        'longitude': -93.265417,
        'contact_email': '',
        'phone': '(844) 836-6688',
        'address': '816 Portland Ave.',
        'city': 'Minneapolis',
        'zip': 55404,
        'city_region': 'East',
        'facebook_url': 'https://www.facebook.com/hqapartments/',
        'instagram_url': '',
        'tour_schedule_url': 'http://www.hqminneapolis.com/contact/',
        'skyway_connected': false
    },
    {
      'property_id': 7,
      'apartment_name': '4 Marq',
      'floor_count': 30,
      'website': 'https://www.4marqapartments.com',
      'short_description': '4Marq is an alluring community of luxury Minneapolis apartments offering top-tier amenities, extravagant homes, and premier resident services all in an extremely desirable location. Each of our spacious one-, two-, and three-bedroom floor plans offer unique features such as floor-to-ceiling windows with spectacular views, 9-foot exposed concrete ceilings and duct-work, plank flooring, granite countertops, designer cabinetry and fixtures, and stainless steel appliances.',
      'long_description': '',
      'latitude': 44.979310,
      'longitude':  -93.268934,
      'contact_email': '',
      'phone': '612-424-8127',
      'address': '400 Marquette Avenue South',
      'city': 'Minneapolis',
      'zip': 55401,
      'city_region': 'East',
      'facebook_url': 'https://www.facebook.com/4Marq',
      'instagram_url': 'https://www.instagram.com/4marqapartments/',
      'tour_schedule_url': '',
      'skyway_connected': false
    }
  ]";
            List<Apartment> apartmentList = JsonConvert.DeserializeObject<List<Apartment>>(json);
            
           
            return apartmentList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void PropertyGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void ApartmentView_Click(object sender, MouseButtonEventArgs e)
        {

            

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (search_txtbox.Text != null)
            {
                sortedApartments = true;
                propGrid.ItemsSource = globalApartmentList.Where(x => x.apartment_Name.ToString().Contains(search_txtbox.Text));
            }
            else if (search_txtbox.Text == "")
            {
                sortedApartments = false;
                propGrid.ItemsSource = globalApartmentList;
            }
        }

        private void PropGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedProperty = propGrid.SelectedIndex;
            Apartment anApartment = ((Apartment)propGrid.Items[selectedProperty]);
            name_txtbox.Text = anApartment.apartment_Name;
            foor_txtbox.Text = anApartment.floor_count.ToString();
            lat_txtbox.Text = anApartment.latitude.ToString();
            long_txtbox.Text = anApartment.longitude.ToString();
            email_txtbox.Text = anApartment.contact_email;
            phone_txtbox.Text = anApartment.phone;
            address_txtbox.Text = anApartment.address;
            city_txtbox.Text = anApartment.city;
            zip_txtbox.Text = anApartment.zip.ToString();
            cityregion_txtbox.Text = anApartment.city_region;
            facebook_txtbox.Text = anApartment.facebook_url;
            gram_txtbox.Text = anApartment.instagram_url;
            tour_txtbox.Text = anApartment.tour_schedule_url;
            skybox_txtbox.IsChecked = anApartment.skyway_connected;
            shortdesc_txtbox.Text = anApartment.short_description;
            longdesc_txtbox.Text = anApartment.long_description;



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (propGrid.SelectedItem != null)
            {
                Apartment selectedApt = (Apartment)propGrid.SelectedItem;
                selectedApt.apartment_Name = name_txtbox.Text;
                selectedApt.floor_count = Int32.Parse(foor_txtbox.Text);
                selectedApt.latitude = Double.Parse(lat_txtbox.Text);
                selectedApt.longitude = Double.Parse(long_txtbox.Text);
                selectedApt.contact_email = email_txtbox.Text;
                selectedApt.phone = phone_txtbox.Text;
                selectedApt.address = address_txtbox.Text;
                selectedApt.city = city_txtbox.Text;
                selectedApt.zip = Int32.Parse(zip_txtbox.Text);
                selectedApt.city_region = cityregion_txtbox.Text;
                selectedApt.facebook_url = facebook_txtbox.Text;
                selectedApt.instagram_url = gram_txtbox.Text;
                selectedApt.tour_schedule_url = tour_txtbox.Text;
                selectedApt.skyway_connected = (bool)skybox_txtbox.IsChecked;
                selectedApt.short_description = shortdesc_txtbox.Text;
                selectedApt.long_description = longdesc_txtbox.Text;

                propGrid.Items.Refresh();
            }
           
            
            





        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (propGrid.SelectedItem != null)
            {
                propGrid.Items.Remove((Apartment)propGrid.SelectedItem);
            }
        }
    }
}
