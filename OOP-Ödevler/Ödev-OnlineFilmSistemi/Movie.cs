using System;
using System.Collections.Generic;

// User sınıfı
public class User
{
    private int userId;
    private string username;
    private bool isSubscriber;
    private int credits;
    private List<Movie> rentedMovies;

    public User(int userId, string username)
    {
        this.userId = userId;
        this.username = username;
        this.isSubscriber = false;
        this.credits = 0;
        this.rentedMovies = new List<Movie>();
    }

    public void PurchaseCredits(int amount)
    {
        credits += amount;
    }

    public bool RentMovie(Movie movie)
    {
        if (isSubscriber)
        {
            if (credits >= movie.Price && movie.IsAvailable)
            {
                credits -= movie.Price;
                movie.RentMovie();
                rentedMovies.Add(movie);
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient credits or movie is not available.");
                return false;
            }
        }
        else
        {
            Console.WriteLine("Only subscribers can rent movies.");
            return false;
        }
    }

    public bool BuyMovie(Movie movie)
    {
        if (credits >= movie.Price)
        {
            credits -= movie.Price;
            movie.BuyMovie();
            return true;
        }
        else
        {
            Console.WriteLine("Insufficient credits to buy the movie.");
            return false;
        }
    }

    public void RequestMovie(string title)
    {
        // Film talep etme işlemi
    }

    public void ReturnMovie(Movie movie)
    {
        rentedMovies.Remove(movie);
        movie.SetAvailability(true);
    }

    public void AddRentedMovie(Movie movie)
    {
        rentedMovies.Add(movie);
    }

    public bool IsMovieRented(Movie movie)
    {
        return rentedMovies.Contains(movie);
    }

    public bool IsSubscriber
    {
        get { return isSubscriber; }
        set { isSubscriber = value; }
    }
}

// Subscriber sınıfı
public class Subscriber
{
    private int subscriptionId;
    private User user;

    public Subscriber(int subscriptionId, User user)
    {
        this.subscriptionId = subscriptionId;
        this.user = user;
        this.user.IsSubscriber = true;
    }
}

// Movie sınıfı
public class Movie
{
    private int movieId;
    private string title;
    private int price;
    private bool isAvailable;

    public Movie(int movieId, string title, int price)
    {
        this.movieId = movieId;
        this.title = title;
        this.price = price;
        this.isAvailable = true;
    }

    public void RentMovie()
    {
        isAvailable = false;
    }

    public void BuyMovie()
    {
        isAvailable = false;
    }

    public void SetAvailability(bool available)
    {
        isAvailable = available;
    }

    public int Price
    {
        get { return price; }
    }

    public bool IsAvailable
    {
        get { return isAvailable; }
    }
}

// MovieRequest sınıfı
public class MovieRequest
{
    private int requestId;
    private string title;
    private bool isFulfilled;

    public MovieRequest(int requestId, string title)
    {
        this.requestId = requestId;
        this.title = title;
        this.isFulfilled = false;
    }
}
