using System;
using System.Collections.Generic;
using Xunit;
using Square_root__TARgv20_;

namespace ParcelTesting
{
    public class UnitTest1
    {
        [Fact]
        public void when_ParcelHasNewDimensionsAndSameWithSortingLine_ThenParcelCanNotFitSortingLine()
        {
            var boxSize = new List<BoxSize>()
            {
            new BoxSize
                {
                    Length = 70,
                    Width = 50,
                    SortingLineParam = new List<SortingLineParam>
                    {
                        new SortingLineParam
                        {
                            Width = 50
                        },
                        new SortingLineParam
                        {
                            Width = 20
                        }
                    }
                }
            };

            //mis koodi peame sisestama
            //kaks rida
            bool result = Program.ParcelLine(boxSize);
            Assert.True(result);
        }

        [Fact]
        public void when_ParcelHasNewDimensionsAndSameWithSortingLine_ThenParcelCanFitSortingLine()
        {
            var boxSize2 = new List<BoxSize>()
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
                }
            };

            //mis koodi peame sisestama
            //kaks rida
            bool result2 = Program.ParcelLine(boxSize2);
            Assert.False(result2);
        }
    }
}
