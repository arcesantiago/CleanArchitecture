using AutoFixture;
using CleanArchitecture.Domain;
using CleanArchitecture.Infrastucture.Persistence;

namespace CleanArchitecture.Application.UnitTests.Mocks
{
    public static class MockVideoRepository
    {
        public static void AddDataVideoRepository(StreamerDbContext streamerDbContextFake)
        {
            var fixture = new Fixture();
            fixture.Behaviors.Add(new OmitOnRecursionBehavior());
            var videos = fixture.CreateMany<Video>().ToList();
            videos.Add(fixture.Build<Video>()
                .With(tr => tr.CreatedBy,"vaxidrez")
                .Create());

            streamerDbContextFake.Videos!.AddRange(videos);
            streamerDbContextFake.SaveChanges();
        }
    }
}
