using System;
using System.Collections.Generic;

namespace Square_root__TARgv20_
{
    public class Program
    {
        static void Main()
        {
            ParcelLine(BoxSize);
        }

        public static bool ParcelLine(List<BoxSize> boxSizes)
        {
            bool parcelFits = false;

            foreach  (BoxSize box in boxSizes)
            {
                Console.WriteLine("\n New sorting line starts");

                var boxLengthInHalf = box.Length / 2;
                var halfBox = (boxLengthInHalf * boxLengthInHalf) + (box.Width * box.Width);
                var halfParcelDiagonal = Math.Sqrt(halfBox);

                var lineWidth = 0;

                foreach (SortingLineParam sortingLine in box.SortingLineParam)
                {
                    var sortmentLineNotSquare = (sortingLine.Width * sortingLine.Width) + (lineWidth * lineWidth);
                    var parcelDiagonal = Math.Sqrt(sortmentLineNotSquare);

                    if (sortingLine.Width >= halfParcelDiagonal)
                    {
                        Console.WriteLine("Sorting line width is {0} and it fits", sortingLine.Width);
                    }

                    else if (sortingLine.Width <= halfParcelDiagonal && lineWidth >= halfParcelDiagonal)
                    {
                        Console.WriteLine("Sorting line width is {0} and it fits", sortingLine.Width);
                    }

                    else if (box.Width <= halfParcelDiagonal && lineWidth >= halfParcelDiagonal)
                    {
                        Console.WriteLine("Sorting line width is {0} and it fits", sortingLine.Width);
                    }

                    else if (box.Width >= halfParcelDiagonal)
                    {
                        Console.WriteLine("Sorting line width is {0} and it fits", sortingLine.Width);
                    }

                    else if (sortingLine.Width <= halfParcelDiagonal && sortingLine.Width >= parcelDiagonal)
                    {
                        parcelFits = sortingLine.Width <= halfParcelDiagonal && sortingLine.Width >= parcelDiagonal;

                        var result = parcelFits ?
                            "Sorting line width is " + sortingLine.Width + " and it fits " :
                            "It does not fit to the sorting line and needs to be wider";

                        Console.WriteLine(result);
                    }

                    else
                    {
                        Console.WriteLine("It did not fit to the sortingline and needs to be wider");
                    }

                    lineWidth = sortingLine.Width;
                }
            }

            return parcelFits;
        }

        public static readonly List<BoxSize> BoxSize = new List<BoxSize>
        {
            new BoxSize
            {
                Length = 120,
                Width = 60,
                SortingLineParam = new List<SortingLineParam>
                {
                    new SortingLineParam
                    {
                        Width = 100
                    },
                    new SortingLineParam
                    {
                        Width = 75
                    }
                }
            },

            new BoxSize
            {
                Length = 100,
                Width = 35,
                SortingLineParam = new List<SortingLineParam>
                {
                    new SortingLineParam
                    {
                        Width = 75
                    },
                    new SortingLineParam
                    {
                        Width = 50
                    },
                    new SortingLineParam
                    {
                        Width = 80
                    },
                    new SortingLineParam
                    {
                        Width = 100
                    },
                    new SortingLineParam
                    {
                        Width = 37
                    }
                }
            },

            new BoxSize
            {
                Length = 70,
                Width = 50,
                SortingLineParam = new List<SortingLineParam>
                {
                    new SortingLineParam
                    {
                        Width = 60
                    },
                    new SortingLineParam
                    {
                        Width = 60
                    },
                    new SortingLineParam
                    {
                        Width = 55
                    },
                    new SortingLineParam
                    {
                        Width = 90
                    }
                }
            }
        };
    }
    public class BoxSize
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public List<SortingLineParam> SortingLineParam { get; set; } = new List<SortingLineParam>();
    }
    public class SortingLineParam
    {
        public int Width { get; set; }
    }
}
