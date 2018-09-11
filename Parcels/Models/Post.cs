using System;
using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    private int _volume;
    private int _weight;
    private int _height;
    private int _length;
    private int _width;
    private int _cost;
    private static List<Parcel> _instances = new List<Parcel> {};

    public Parcel(string length, string width, int height, int weight,int volume, int cost)
    {
      _volume = volume;//dimensions
      _width = width;
      _weight = weight;
      _height = height;
      _length = length;
      _cost = cost;
    }

    public int GetWidth()
    {
      return _width; //need to be switched with get. Think "What do I  --GET-- in --return--"
    }
    public void SetWidth(int width)
    {
      _width = width;
    }

    public int GetWeight()
    {
      return _weight;
    }
    public void SetWeight(int weight)
    {
      _weight = weight;
    }
    public int GetLength()
    {
      return _weight;
    }
    public void SetLength(int length)
    {
      _length = length;
    }
    public int GetHeight()
    {
      return _height;
    }
    public void SetHeight(int height)
    {
      _height = height;
    }
    public int GetVolume()
    {
      return _length * _width * _height;
    }
    public void SetVolume(int volume)
    {
      _volume = volume;
    }
    public int GetCost()
    {
      return (_length * _height) /2;
    }
    public void SetCost(int cost)
    {
      _cost = cost;
    }
    public static List<Parcel> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }

  }
}
