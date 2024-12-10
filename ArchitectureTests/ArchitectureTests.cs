using FluentAssertions;
using NetArchTest.Rules;

namespace ArchitectureTests
{
    public class ArchitectureTests
    {
        private const string ApplicationNamespace = "Application";
        private const string InfrastructureNamespace = "Infrastructure";
        private const string PresentationNamespace = "ZadanieRekrutacyjne";

        [Fact]
        public void Domain_Should_Not_HaveDependencyOnOtherProjects()
        {
            var assembly = typeof(Domain.AssemblyReference).Assembly;

            var otherProjects = new[]
            {
                ApplicationNamespace,
                InfrastructureNamespace,
                PresentationNamespace
            };

            var testResult = Types
                .InAssembly(assembly)
                .ShouldNot()
                .HaveDependencyOnAny(otherProjects)
                .GetResult();

            testResult.IsSuccessful.Should().BeTrue();
        }

        [Fact]
        public void Application_Should_Not_HaveDependencyOnInfrastructureAndPresentation()
        {
            var assembly = typeof(Application.AssemblyReference).Assembly;

            var otherProjects = new[]
            {
                InfrastructureNamespace,
                PresentationNamespace
            };

            var testResult = Types
                .InAssembly(assembly)
                .ShouldNot()
                .HaveDependencyOnAny(otherProjects)
                .GetResult();

            testResult.IsSuccessful.Should().BeTrue();
        }

        [Fact]
        public void Infrastructure_Should_Not_HaveDependencyOnPresentation()
        {
            var assembly = typeof(Infrastructure.AssemblyReference).Assembly;

            var testResult = Types
                .InAssembly(assembly)
                .ShouldNot()
                .HaveDependencyOn(PresentationNamespace)
                .GetResult();

            testResult.IsSuccessful.Should().BeTrue();
        }

        [Fact]
        public void Presentation_Should_Not_HaveDependencyOnInfrastructure()
        {
            var assembly = typeof(ZadanieRekrutacyjne.AssemblyReference).Assembly;

            var testResult = Types
                .InAssembly(assembly)
                .ShouldNot()
                .HaveDependencyOn(InfrastructureNamespace)
                .GetResult();

            testResult.IsSuccessful.Should().BeTrue();
        }
    }
}
