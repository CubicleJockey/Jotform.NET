﻿using System.Text.Json;

namespace Jotform.Utils;

public static class AnswerDictionaryExtensions
{
    public static T GetAnswerValueByName<T>(this IDictionary<int, Answer> answers, string answerName, bool isJson = false, JsonSerializerOptions jsonSerializerOptions = default!)
    {
        var (_, answerFound) = answers.FirstOrDefault(answer => answer.Value.Name == answerName);
        if (answerFound == default) { return default!; }

        try
        {
            if (!isJson)
            {
                return (T)answerFound.UserResponse;
            }

            var json = answerFound.UserResponse as string;
            if (string.IsNullOrWhiteSpace(json)) { return default!; }
            return JsonSerializer.Deserialize<T>(json, jsonSerializerOptions ?? JsonSerializerOptions.Default)!;
        }
        catch { return default!; }
    }
}