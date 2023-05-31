﻿namespace LearningCenter.Infrastructure.Models;

public class Exercise
{
    public int Id { get; set; }
    public string Question { get; set; }
    public List<Answer> Answers { get; set; }
    public int ModuleId { get; set; }
}