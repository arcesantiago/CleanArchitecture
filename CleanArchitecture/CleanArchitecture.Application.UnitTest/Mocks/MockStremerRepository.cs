using AutoFixture;
using CleanArchitecture.Domain;
using CleanArchitecture.Infrastucture.Persistence;

namespace CleanArchitecture.Application.UnitTests.Mocks
{
    public static class MockStremerRepository
    {
        public static void AddDataStreamerRepository(StreamerDbContext streamerDbContextFake)
        {
            var fixture = new Fixture();
            fixture.Behaviors.Add(new OmitOnRecursionBehavior());

            var streamers = fixture.CreateMany<Streamer>().ToList();

            streamers.Add(fixture.Build<Streamer>()
                .With(tr => tr.Id, 1)
                .Without(tr => tr.Videos)
                .Create());

            streamerDbContextFake.Streamers!.AddRange(streamers);
            streamerDbContextFake.SaveChanges();
        }
    }
}
