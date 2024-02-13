﻿namespace BO;
public class TaskInList
{
    public int Id { get; init; }
    public string? Description { get; init; }
    public string? Alias { get; init; }
    public Status Status { get; init; }

    public override string ToString()
    {
        return $"Id: {Id}, Description: {Description ?? "N/A"}, Alias: {Alias ?? "N/A"}, Status: {Status}";
    }
}