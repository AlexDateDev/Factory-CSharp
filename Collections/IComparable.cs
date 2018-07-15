// ----------------------------------------------------------------------------
// Título:    IComparable
//
// Fecha:     02/01/2015
// Autor:    Alex Solé
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils.Collections
{
    class ProgramDemo1
    {
        private void ListCars( )
        {
            var cars = new List<Car>
            {
                { new Car() { Name = "car1", Color = "blue", Speed = 20}},
                { new Car() { Name = "car2", Color = "red", Speed = 50}},
                { new Car() { Name = "car3", Color = "green", Speed = 10}},
                { new Car() { Name = "car4", Color = "blue", Speed = 50}},
                { new Car() { Name = "car5", Color = "blue", Speed = 30}},
                { new Car() { Name = "car6", Color = "red", Speed = 60}},
                { new Car() { Name = "car7", Color = "green", Speed = 50}}
            };

            // Sort the cars by color alphabetically, and then by speed
            // in descending order.
            cars.Sort( );

            // View all of the cars.
            foreach( Car thisCar in cars ) {
                Console.Write( thisCar.Color.PadRight( 5 ) + " " );
                Console.Write( thisCar.Speed.ToString( ) + " " );
                Console.Write( thisCar.Name );
                Console.WriteLine( );
            }

            // Output:
            //  blue  50 car4
            //  blue  30 car5
            //  blue  20 car1
            //  green 50 car7
            //  green 10 car3
            //  red   60 car6
            //  red   50 car2
        }



    }

    public class Car : IComparable<Car>
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }

        public int CompareTo( Car other )
        {
            // A call to this method makes a single comparison that is
            // used for sorting.

            // Determine the relative order of the objects being compared.
            // Sort by color alphabetically, and then by speed in
            // descending order.

            // Compare the colors.
            int compare;
            compare = String.Compare( this.Color, other.Color, true );

            // If the colors are the same, compare the speeds.
            if( compare == 0 ) {
                compare = this.Speed.CompareTo( other.Speed );

                // Use descending order for speed.
                compare = -compare;
            }

            return compare;
        }
    }
}

