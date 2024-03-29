﻿using AggregatorService.DTOs;

namespace AggregatorService.Abstractions
{
    public interface ICourseUserService
    {
        Task<CourseDto> GetCourse(string courseId);
        Task<List<UserDto>> GetUsers(string courseId);
        Task AddCourseAsync(string courseId, string userId);
        Task SaveChangesAsync();
    }
}
