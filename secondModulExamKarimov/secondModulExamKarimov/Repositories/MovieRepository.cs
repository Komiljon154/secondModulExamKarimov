using System.Collections.Generic;
using System.Text.Json;
using secondModulExamKarimov.DataAccess.Entities;
using secondModulExamKarimov.Services.DTOs;
namespace _2._7_dars.Repositories;

public class MovieRepository : IMovieRepository
{
    private readonly MovieDto _movieDto;
    private List<Movie> _movie;

    string _path = "../../../DataAccess/Data/Movies.json";

    public void MovieRepostory()
    {
        _path = "../../../DataAccess/Data/Movies.json";
        _movie = new List<Movie>();

        if (!File.Exists(_path))
        {
            File.WriteAllText(_path, "[]");
        }

        _movie = GetAllMovies();
    }
    public bool AddMovie(Movie movie)
    {
        _movie.Add(movie);
        return true;
    }


    public List<Movie> GetAllMovies()
    {
        var studentJson = File.ReadAllText(_path);
        var students = JsonSerializer.Deserialize<List<Movie>>(studentJson);
        return students;
    }

    public List<MovieDto> GetAllMoviesByDirector(Movie direktor)
    {
        MovieDto values = new List<MovieDto>();
        foreach (var director in _movie)
        {
            return Director;
        }
        SaveData();
        return null;
    }

    private Movie GetById(Guid id)
    {
        foreach (var movie in _movie)
        {
            if (movie.Id != id)
            {
                continue;
            }
            return movie;
        }
        throw new Exception($"{id}\n Not found");
    }


    public MovieDto GetHighestGrossingmovie()
    {
        throw new NotImplementedException();
    }

    public List<MovieDto> GetMoviesReleasedAfterYear(int year)
    {
        throw new NotImplementedException();
    }

    public List<MovieDto> GetMoviesSortedByRating()
    {
        throw new NotImplementedException();
    }

    public List<MovieDto> GetMoviesWithinDurationRange(int minMinutes, int maxMinutes)
    {
        throw new NotImplementedException();
    }

    public List<MovieDto> GetRecentMovies(int years)
    {
        throw new NotImplementedException();
    }

    public MovieDto GetTopRatedMovie(string director)
    {
        throw new NotImplementedException();
    }

    public long GetTotalBoxOfficeEarningsByDirector(string director)
    {
        throw new NotImplementedException();
    }

    public List<MovieDto> SearchMoviesByTitle(string keyword)
    {

        foreach (MovieDto movie in _movie)
        {
            var movieName = "";
            movieName.
        }
    }

    public bool UpdateMovie(Movie movie)
    {
        var updatingMovie = GetById(movie.Id);
        var index = _movie.IndexOf(updatingMovie);
        _movie[index] = movie;
        SaveData();
        return true;
    }
    public void SaveData()
    {
        var movieJson = JsonSerializer.Serialize(_movie);
        File.WriteAllText(_path, movieJson);
    }

    public bool DeleteMovie(Guid id)
    {
        var movie = GetById(id);
        _movie.Remove(movie);
        SaveData();
        return true;
    }


}


