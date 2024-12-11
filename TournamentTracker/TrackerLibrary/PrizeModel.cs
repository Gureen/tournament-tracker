using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        public int Id { get; set; }
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PrizeAmount { get; set; }
        public double PrizePercentage { get; set; }

        public PrizeModel()
        { }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;
            Console.WriteLine($"PlaceName: '{PlaceName}'");

            int placeNumberValue = 0;
            bool isPlaceNumberValid = int.TryParse(placeNumber.Trim(), out placeNumberValue);
            if (isPlaceNumberValid)
            {
                PlaceNumber = placeNumberValue;
            }
            else
            {
                Console.WriteLine("Failed to parse Place Number.");
                PlaceNumber = 0; 
            }
            Console.WriteLine($"PlaceNumber: {PlaceNumber}");

            decimal prizeAmountValue = 0;
            bool isPrizeAmountValid = decimal.TryParse(prizeAmount.Trim(), out prizeAmountValue);
            if (isPrizeAmountValid)
            {
                PrizeAmount = prizeAmountValue;
            }
            else
            {
                Console.WriteLine("Failed to parse Prize Amount.");
                PrizeAmount = 0; 
            }
            Console.WriteLine($"PrizeAmount: {PrizeAmount}");

            double prizePercentageValue = 0;
            bool isPrizePercentageValid = double.TryParse(prizePercentage.Trim(), out prizePercentageValue);
            if (isPrizePercentageValid)
            {
                PrizePercentage = prizePercentageValue;
            }
            else
            {
                Console.WriteLine("Failed to parse Prize Percentage.");
                PrizePercentage = 0; 
            }
            Console.WriteLine($"PrizePercentage: {PrizePercentage}");
        }
    }
    }
