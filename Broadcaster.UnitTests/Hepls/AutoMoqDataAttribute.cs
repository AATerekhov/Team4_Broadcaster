using AutoFixture.AutoMoq;
using AutoFixture.Community.AutoMapper;
using AutoFixture;
using AutoFixture.Xunit2;
using Broadcaster.UnitTests.Application.HabitNotification;
using Broadcaster.Application.Services.Implementations.Mapping;

namespace Broadcaster.UnitTests.Hepls
{
    public class AutoMoqDataAttribute : AutoDataAttribute
    {
        public AutoMoqDataAttribute() : base(fixtureFactory: fixtureFactory)
        { }
        private static readonly Func<IFixture> fixtureFactory = () =>
        {
            var fixture = new Fixture().Customize(new AutoMoqCustomization());
            fixture.Customize<GetHabitNotification>(c => c.OmitAutoProperties());
            fixture.Customize(new AutoMapperCustomization(cfg =>
            {
                cfg.AddProfile<HabitNotificationMapping>();
            }));
            return fixture;
        };
    }
}
