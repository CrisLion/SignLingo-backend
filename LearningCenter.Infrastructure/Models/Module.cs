﻿namespace LearningCenter.Infrastructure.Models;

public class Module
{
    public int Id { get; set; }
    public string Module_Name { get; set; }
    public List<Exercise> Exercises { get; set; }
}