using System.Collections.Generic;

namespace lab1v7
{
    public class FirstPartTest
    {
        
        [Fact]
        public void IsMinIndexValid()
        {
            FirstPart first = new FirstPart();
            double[] array = { 4.4, 6.5, -0.9, -8.5, 6.2 };
            int result = first.MinIndex(array);
            Assert.Equal(3, result);
        }

        [Fact]
        public void IsSummaValid()
        {
            FirstPart first = new FirstPart();
            double[] array = { 4.4, 6.5, -0.9, -8.5, 6.2 };
            double result = first.Summa(array);
            Assert.Equal(0, result);
        }

        [Fact]
        public void IsZeroValid()
        {
            FirstPart first = new FirstPart();
            double[] array = { 4.4, 6.5, 0.9, 8.5, 6.2 };
            double result = first.Summa(array);
            Assert.Equal(0, result);
        }

        [Fact]
        public void IsTransformValid()
        {
            FirstPart first = new FirstPart();
            double[] array = { 4.4, 6.5, -0.9, -8.5, 6.2 };
            first.TransformArray(array);
            double[] expectedArray = { -0.9, 6.5, 4.4, -8.5, 6.2 };
            Assert.Equal(expectedArray, array);
        }
    }
}