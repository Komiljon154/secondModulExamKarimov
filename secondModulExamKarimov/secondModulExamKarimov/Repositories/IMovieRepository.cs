using secondModulExamKarimov.DataAccess.Entities;
using secondModulExamKarimov.Services.DTOs;

namespace _2._7_dars.Repositories
{
    public interface IMovieRepository
    {

            bool AddMovie(Movie movie);
            bool UpdateMovie(Movie movie);
            bool DeleteMovie(Movie movie);
            Movie GetById(Guid id);
            List<Movie> GetAllMovies();
            List<MovieDto> GetAllMoviesByDirector(string director);
            MovieDto GetTopRatedMovie(string director);
            List<MovieDto> GetMoviesReleasedAfterYear(int year);
            MovieDto GetHighestGrossingmovie();
            List<MovieDto> SearchMoviesByTitle(string keyword);
            List<MovieDto> GetMoviesWithinDurationRange(int minMinutes, int maxMinutes);
            long GetTotalBoxOfficeEarningsByDirector(string director);
            List<MovieDto> GetMoviesSortedByRating();
            List<MovieDto> GetRecentMovies(int years);
        List<MovieDto> GetAllMoviesByDirector(Movie direktor);
    }