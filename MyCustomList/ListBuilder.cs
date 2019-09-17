using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomList
{
    public class ListBuilder
    {
        public bool isOn = false;
        public ListBuilder()
        {
            
        }

        // INTEGER LIST
        public void RunListMenu(CustomList<int> list)
        {
            isOn = true;

            while (isOn)
            {
                int userInput = UI.GetListMenuResponse();

                switch (userInput)
                {
                    case 1:
                        // view list
                        // UI.DisplayList("ints", list)
                        break;

                    case 2:
                        // add to list
                        // UI.GetItemToAdd("ints",list)
                        break;

                    case 3:
                        // remove from list
                        // UI.GetItemToRemove("ints",list)
                        break;

                    case 4:
                        isOn = false;
                        break;

                    default:
                        RunListMenu(list);
                        break;
                }
            }
        }
        // STRING LIST
        public void RunListMenu(CustomList<string> list)
        {
            isOn = true;

            while (isOn)
            {
                int userInput = UI.GetListMenuResponse();

                switch (userInput)
                {
                    case 1:
                        // view list
                        break;

                    case 2:
                        // add to list
                        break;

                    case 3:
                        // remove from list
                        break;

                    case 4:
                        isOn = false;
                        break;

                    default:
                        RunListMenu(list);
                        break;
                }
            }
        }

        // DOUBLE LIST
        public void RunListMenu(CustomList<double> list)
        {
            isOn = true;

            while (isOn)
            {
                int userInput = UI.GetListMenuResponse();

                switch (userInput)
                {
                    case 1:
                        // view list
                        break;

                    case 2:
                        // add to list
                        break;

                    case 3:
                        // remove from list
                        break;

                    case 4:
                        isOn = false;
                        break;

                    default:
                        RunListMenu(list);
                        break;
                }
            }
        }

        public void GetListType()
        {
            int listType = UI.GetListType();

            switch (listType)
            {
                case 1:
                    CustomList<int> listOfInts = new CustomList<int>();
                    RunListMenu(listOfInts);
                    break;

                case 2:
                    CustomList<string> listOfStrings = new CustomList<string>();
                    RunListMenu(listOfStrings);
                    break;

                case 3:
                    CustomList<double> listOfDoubles = new CustomList<double>();
                    RunListMenu(listOfDoubles);
                    break;

                default:
                    break;
            }
        }
    }
}
