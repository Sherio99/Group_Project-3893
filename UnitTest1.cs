using Xunit;
using FluentAssertions;
using Group_project;

namespace Group_Project.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CalculateGpa_WithNoModules_ReturnsZero()
        {
            // Arrange
            var studentService = new StudentService();

            // Act
            double result = studentService.CalculateGpa();

            // Assert
            result.Should().Be(0);
        }

        [Theory]
        [InlineData(80, 4, 85, 3, 90, 2)]
        [InlineData(65, 3, 90, 4, 75, 2)]
        [InlineData(50, 3, 65, 2, 85, 4)]
        [InlineData(35, 2, 40, 1, 50, 3)]
        public void CalculateGpa_WithValidMarks_ReturnsExpectedGpa(
            int marks1, int credit1, int marks2, int credit2, int marks3, int credit3)
        {
            // Arrange
            var studentService = new StudentService();

            studentService.modules.Add(new ModuleClass { Marks = marks1, Credit = credit1 });
            studentService.modules.Add(new ModuleClass { Marks = marks2, Credit = credit2 });
            studentService.modules.Add(new ModuleClass { Marks = marks3, Credit = credit3 });

            double expectedGpa = ((4 * marks1 + 3 * marks2 + 2 * marks3) * 1.0) / (credit1 + credit2 + credit3);

            // Act
            double result = studentService.CalculateGpa();

            // Assert
            result.Should().BeApproximately(expectedGpa, 0.01); // Allow small tolerance for floating-point calculations
        }

        // Add more test cases to cover other scenarios, such as invalid input, edge cases, etc.
    }
}
