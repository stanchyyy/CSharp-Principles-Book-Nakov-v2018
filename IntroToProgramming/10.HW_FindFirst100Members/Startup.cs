using System;
using System.Collections.Generic;

namespace _10.HW_FindFirst100Members
{
    class Startup
    {
        static void Main(string[] args)
        {
            //Task 10: Write program that prints the first 100 members of the row 2,-3, 4, -5, 6, -7, 8.
            List<int> sequence = new List<int> { 2, -3, 4, -5, 6, -7, 8 };
            int membersToPrint = 100;

            List<int> rowA = new List<int> { };
            List<int> rowB = new List<int> { };

            for (int i = 0; i < sequence.Count; i++)
            {
                if (i%2==0)
                {
                    rowA.Add(sequence[i]);
                }
                else
                {
                    rowB.Add(sequence[i]);
                }
            }

            List<int> members = new List<int> { };

            int rowAFirstMember = rowA[0];
            int rowBFirstMember = rowB[0];

            members.Add(rowAFirstMember);
            members.Add(rowBFirstMember);

            int rowACommonDifference = rowA[rowA.Count - 1] - rowA[rowA.Count - 2];
            int rowBCommonDifference = rowB[rowB.Count - 1] - rowB[rowB.Count - 2];

            int counter = members.Count;
            int aMemberToAdd = rowAFirstMember;
            int bMemberToAdd = rowBFirstMember;
            do
            {
                aMemberToAdd += rowACommonDifference;
                members.Add(aMemberToAdd);
                counter++;

                if (counter<membersToPrint)
                {
                    bMemberToAdd += rowBCommonDifference;
                    members.Add(bMemberToAdd);
                    counter++;
                 }
                    } while (counter<membersToPrint);
            Console.WriteLine(string.Join(",", members));
        }
        }
    }