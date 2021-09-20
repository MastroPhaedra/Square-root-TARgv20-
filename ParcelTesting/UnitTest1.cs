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
        }
    }
}
