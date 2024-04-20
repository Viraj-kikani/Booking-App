using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment1VK
{
    

    public partial class Form1 : Form
    {
        static Class1[] booking = new Class1[12];
        static Pending[] pending = new Pending[12];
        int currentIndex = 0;
        int pendingIndex = 0;
        string seats = string.Empty;
        string name = string.Empty;


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void UpdateSeatInformation()
        {
            int totalSeats = booking.Length;
            int bookedSeats = booking.Count(b => b != null);
            int availableSeats = totalSeats - bookedSeats;
            int capacity = (int)((bookedSeats / (double)totalSeats) * 100);

            status.Text = $"Available Seats: {availableSeats} | Booked Seats: {bookedSeats} | Capacity: {capacity}%";
        }

        
        private void CheckAndBookFromPendingList()
        {
               
            for (int i = 0; i < pendingIndex; i++)
            {
                if (currentIndex >= 12)
                {
                    break;
                }

                Pending pendingBooking = pending[i];
                if (pendingBooking == null)
                {
                    continue;
                }

                // Check if the seat has already been booked
                bool isSeatBooked = booking.Any(b => b?.GetSeats() == pendingBooking.GetPSeats());
                if (isSeatBooked)
                {
                    continue;
                }

                // Book the seat
                booking[currentIndex] = new Class1(pendingBooking.GetPSeats(), pendingBooking.GetPName());
                currentIndex++;

                // Update the seat color and display booking information
                foreach (Control seat in grpVenue.Controls)
                {
                    if (seat.Text == pendingBooking.GetPSeats())
                    {
                        seat.BackColor = Color.Red;
                        lblInfo.ForeColor = Color.DarkGreen;
                        lblInfo.Text = pendingBooking.GetPSeats() + " is booked by " + pendingBooking.GetPName();
                        seat.MouseHover += (s, ev) =>
                        {
                            ToolTip tt = new ToolTip();
                            tt.Show("Seat is booked by " + pendingBooking.GetPName(), (Button)s, 0, -20, 2000);
                        };
                        break;
                    }
                }

                // Remove the booking from pending list
                pending[i] = null;

                // Decrement the pending index
                pendingIndex--;
            }

            UpdateSeatInformation();
        }






        private void btnBook_Click(object sender, EventArgs e)
        {
            string seats = string.Empty;
            seats = lstRows.Text + lstColums.Text;
            string name;
            name = nameOfCust.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a name first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(seats))
            {
                lblInfo.Text = "Please select seats first.";
                MessageBox.Show("Please select seats first.");
                return;
            }

            if (currentIndex > 15)
            {
                for (int i = 0; i < 12; i++)
                {
                    pending[currentIndex] = new Pending(seats, name);
                    currentIndex++;
                }
            }
            else
            {
                //Check if the seat has already been booked
                bool isSeatBooked = booking.Any(b => b?.GetSeats() == seats);
                if (isSeatBooked)
                {
                    lblInfo.Text = seats + " is already booked, Please select another seat";
                    MessageBox.Show(seats + " is already booked, Please select another seat");
                    return;
                }

               // Book the seat
               booking[currentIndex] = new Class1(seats, name);
                currentIndex++;

                //Update the seat color and display booking information
                foreach (Control seat in grpVenue.Controls)
                {
                    if (seat.Text == seats)
                    {
                        seat.BackColor = Color.Red;
                        nameOfCust.Text = "";
                        lstRows.ClearSelected();
                        lstColums.ClearSelected();
                        lblInfo.ForeColor = Color.DarkGreen;
                        lblInfo.Text = seats + " is booked by " + name;
                        seat.MouseHover += (s, ev) =>
                        {
                            ToolTip tt = new ToolTip();
                            tt.Show("Seat is booked by " + name, (Button)s, 0, -20, 2000);
                        };
                        break;
                    }
                }
                UpdateSeatInformation();
            }
        }







        private void allSeats_Click(object sender, EventArgs e)
        {
            string name = nameOfCust.Text;
            
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                lblInfo.Text = "Please write name first";
                MessageBox.Show("Please write name first");
            }
            else
            {
                for (int j = 0; j < 12; j++)
                {
                    grpVenue.Controls[j].BackColor = Color.Red;
                    booking[j] = new Class1(grpVenue.Controls[j].Text, nameOfCust.Text);
                    lblInfo.Text = "All seats are booked by " + name;
                    
                }
            }
            UpdateSeatInformation();

        }

        private void cancelBooking_Click(object sender, EventArgs e)
        {
            int bookedSeats = booking.Count(b => b != null);
            if (bookedSeats == 0)
            {
                MessageBox.Show("No seats are booked yet.");
                return;
            }

            // Loop through all elements of the booking array
            for (int i = 0; i < 12; i++)
            {
                booking[i] = null;
                grpVenue.Controls[i].BackColor = Color.Lime;

            }

            MessageBox.Show("All bookings are cancelled");
            lblInfo.Text = "All bookings are cancelled";
        }






        private void btnCancel_Click(object sender, EventArgs e)
        {
                // Collect the seat information
                string seats = string.Empty;
                seats = lstRows.Text + lstColums.Text;
                string name = nameOfCust.Text;

                // Check if customer name is entered
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Please enter the customer name.");
                    return;
                }

                // Check if seat is selected
                if (string.IsNullOrWhiteSpace(seats))
                {
                    MessageBox.Show("Please select the seat.");
                    return;
                }

                // Check if seat is selected properly
                if (lstRows.Text == null || lstColums.Text == null)
                {
                    MessageBox.Show("Please select the seat properly.");
                    return;
                }

                // Confirm the cancellation
                DialogResult result = MessageBox.Show("Are you sure you want to cancel the booking for " + seats + "?", "Confirm Cancellation", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }

                int index = -1;
                for (int i = 0; i < booking.Length; i++)
                {
                    // Find the booking for the given seat and customer name
                    if (booking[i] != null && booking[i].GetSeats() == seats && booking[i].GetName() == name)
                    {
                        index = i;
                        break;
                    }
                }

                // If booking not found
                if (index == -1)
                {
                    MessageBox.Show("No such booking found.");
                    return;
                }

                // Cancel the booking
                booking[index] = null;

                // Change the color of the seat
                foreach (Control seat in grpVenue.Controls)
                {
                    if (seat.Text == seats)
                    {
                        seat.BackColor = Color.Lime;
                        nameOfCust.Text = "";
                        lstRows.ClearSelected();
                        lstColums.ClearSelected();
                        lblInfo.ForeColor = Color.DarkGreen;
                        lblInfo.Text = seats + " is cancelled by " + name;
                        break;
                    }
                }
            UpdateSeatInformation();
        }







        private void btnPending_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 12)
            {
                pending[pendingIndex] = new Pending(seats, name);
                pendingIndex++;

                lblInfo.ForeColor = Color.DarkOrange;
                lblInfo.Text = seats + " is added to the pending list for " + name;

                CheckAndBookFromPendingList();
            }
        }
    }
}