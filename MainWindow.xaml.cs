using System;
using System.Collections.Generic;
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

namespace BinaryNotes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Binary (Used by Mark Zuckerberg in the Social Network film)
            //Binary search's are one of the most common and efficient ways to search through big lists of data. Huge companies like Facebook use binary search to narrow down a 2.5 billion list of users to less than 40.May 11, 2019

            string filePath = "names.bin";



            //Method
            //takes name, object, string
            //Name bander = new Name("Bander");

            names.Add(new Name("Bander"));

            string filePath = "names.bin";

            // creating a binary file with our data
            //insecure method so it's not really used much today bc anybody can access it and change it.
            //serializing our data will store our data in a specified location 
            Serialize(names, filePath);
            //Deserialize will be used to convert a .json binary file to usable data in our Project



            //.json file is built by javascript and it's a file that stores all the data of our Project. Each object is contained in it's own { } curly brackets, but each object on the same table is in 1 parent { } curly brackets
            //.json file backend stores instance data
            //while frontend stores packages/tools that are needed to do things like read/return backend .json file



            //Inside a .json coding structure, we typically have a Key Value Pair (ex. { id : "xxx" ; name: "asfas" }

            // When making a default constructure for our .json coding structure, .json requires at least a constructor with null values (null fields requested)



        }

        public void Serialize(List<Name> name, string filePath )
        {
            // open the filePath you want to use to store the binary .json file

            //Format the object as Binary

            //I serialize the employee object
            ms.Flush();
            ms.Close();
            ms.Dispose();

        }


        #region BinaryExample






        //classes can be inside of mainwindow, did it bc it was small

        // At the top of my class, I add whats known as a data annotation
        // [Serializable]
        [Serializable]
        public class Name
        {

        }




        public void Deserialize(string filePath)
        {

        }


        public override string ToString()
        {
            return; //Text
        }
    }
}


/*
Questions:

What does .csv stand for?
comma-separated values

What package do we use to help import CSV files?
csv helper

What keyword do we use when reading and saving to files?
Serialize

What's the different between FileMode.Append and FileMode.OpenOrCreate?
Append opens a file if it exists and seeks to the end of the file, or creates a new file. 
OpenOrCreate opens a file if it exists, otherwise a new file should be created.

It's wise to save your file locations in a ______ class so that all files can access the same file locations.
Public

*/