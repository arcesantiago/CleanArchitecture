using CleanArchitecture.Data;
using CleanArchitecture.Domain;
using Microsoft.EntityFrameworkCore;

//PARTE 1-----------------------------------------

//StreamerDbContext dbContext = new();

//Streamer streamer = new()
//{
//    Nombre = "Amazon Prime",
//    Url = "https://www.amazonprime.com"
//};

//await dbContext!.Streamers!.AddAsync(streamer);

//await dbContext.SaveChangesAsync();

//var movies = new List<Video>
//{
//    new Video
//    {
//        Nombre = "MadMax",
//        StreamerId = streamer.Id,

//    },
//    new Video
//    {
//        Nombre = "Batman",
//        StreamerId = streamer.Id,

//    },
//    new Video
//    {
//        Nombre = "Crecuspulo",
//        StreamerId = streamer.Id,

//    },
//    new Video
//    {
//        Nombre = "La mascara",
//        StreamerId = streamer.Id,

//    }
//};

//await dbContext.AddRangeAsync(movies);

//await dbContext.SaveChangesAsync();

//PARTE 2-----------------------------------------

//await QueryFilter();



//async Task QueryFilter()
//{
//    Console.WriteLine("Ingrese una compania de streaming:");
//    var streamingNombre = Console.ReadLine();
//    var streamers = await dbContext!.Streamers!.Where(x => x.Nombre.Equals(streamingNombre)).ToListAsync();

//    foreach (var streamer in streamers)
//    {
//        Console.WriteLine($"{streamer.Id } - {streamer.Nombre }");
//    }

//    //var streamerPartialResults = await dbContext!.Streamers!.Where(x => x.Nombre.Contains(streamingNombre)).ToListAsync();
//    var streamerPartialResults = await dbContext!.Streamers!.Where(x => EF.Functions.Like(x.Nombre, $"%{streamingNombre}%")).ToListAsync();

//    foreach (var streamer in streamerPartialResults)
//    {
//        Console.WriteLine($"{streamer.Id} - {streamer.Nombre}");
//    }
//}

//PARTE 3-----------------------------------------
//await QueryMthods();

//async Task QueryMthods()
//{
//    var streamer = dbContext!.Streamers!;
//    var firstAsync = await streamer.Where(x => x.Nombre.Contains("a")).FirstAsync();
//    var firstOrDefaultAsync = await streamer.Where(x => x.Nombre.Contains("a")).FirstOrDefaultAsync();
//    var firstOrDefaultAsync_v2 = await streamer.FirstOrDefaultAsync(x => x.Nombre.Contains("a"));
//    var singleAsync = await streamer.SingleAsync(x => x.Id == 1);
//    var singleOrDefaultAsync = await streamer.SingleOrDefaultAsync(x => x.Id == 1);

//    var resultado = await streamer.FindAsync(1);
//}

//PARTE 4-----------------------------------------

//await QueryLinq();

//async Task QueryLinq()
//{
//    Console.WriteLine("Ingrese un nombre");
//    var streamNombre = Console.ReadLine();

//    var streamers = await (from i in dbContext.Streamers
//                           where EF.Functions.Like(i.Nombre,$"%{streamNombre}%")
//                           select i).ToListAsync();

//    foreach (var streamer in streamers)
//    {
//        Console.WriteLine($"{streamer.Id} - {streamer.Nombre}");
//    }
//}

//PARTE 4-----------------------------------------

//await TrackingAndNotTracking();

//async Task TrackingAndNotTracking()
//{
//    var streamerWithTracking = await dbContext!.Streamers!.FirstOrDefaultAsync(x => x.Id == 1);
//    var streamerWithNoTracking = await dbContext!.Streamers!.AsNoTracking().FirstOrDefaultAsync(x => x.Id == 2);

//    streamerWithTracking.Nombre = "Netflix super";
//    streamerWithNoTracking.Nombre = "Amazon Plus";

//    await dbContext!.SaveChangesAsync();
//}

//PARTE 5----------------------------------------

//await MultipleEntitiesQuery();

//Console.WriteLine("Presione cualquier tecla para cerrar el programa");
//Console.ReadKey();

//async Task AddNewStreamerWithVideo()
//{
//    var pantaya = new Streamer
//    {
//        Nombre = "Pantaya"
//    };

//    var hungerGames = new Video
//    {
//        Nombre = "Hunger Games",
//        Streamer = pantaya
//    };

//    await dbContext.AddAsync(hungerGames);
//    await dbContext.SaveChangesAsync();
//}

//async Task AddNewStreamerWithVideoId()
//{
//    var batmanForever = new Video
//    {
//        Nombre = "Hunger Games",
//        StreamerId = 1002
//    };

//    await dbContext.AddAsync(batmanForever);
//    await dbContext.SaveChangesAsync();
//}

//async Task AddNewActorWithVideo()
//{
//    var actor = new Actor
//    {
//        Nombre = "Brad",
//        Apellido = "Pit"
//    };

//    await dbContext.AddAsync(actor);
//    await dbContext.SaveChangesAsync();

//    var videoActor = new VideoActor
//    {
//        ActorId = actor.Id,
//        VideoId = 1
//    };

//    await dbContext.AddAsync(videoActor);
//    await dbContext.SaveChangesAsync();
//}

//async Task AddNewDirectorWithVideo()
//{
//    var director = new Director
//    {
//        Nombre = "Lorenzo",
//        Apellido = "Basteri",
//        VideoId = 1
//    };

//    await dbContext.AddAsync(director);
//    await dbContext.SaveChangesAsync();
//}

//async Task MultipleEntitiesQuery()
//{
//    var videoWhitActores = await dbContext!.Videos!.Include(q => q.Actores).FirstOrDefaultAsync(q => q.Id == 1);

//    var actor = await dbContext!.Actores!.Select(q => q.Nombre).ToListAsync();

//    var videoWithDirector = await dbContext!.Videos!
//        .Where(q => q.Director != null)
//        .Include(q => q.Director)
//        .Select(q =>
//            new
//            {
//                Director_Nombre_Completo = $"{q.Director.Nombre} {q.Director.Apellido}",
//                Movie = q.Nombre
//            }
//        ).ToListAsync();

//    foreach (var pelicula in videoWithDirector)
//    {
//        Console.WriteLine($"{pelicula.Movie} - {pelicula.Director_Nombre_Completo}");
//    }
//}