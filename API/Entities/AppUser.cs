using System;

namespace API.Entities;

public class AppUser
{
    // EF works only with public properties, not be able to work with private or internal properties
    public int Id { get; set; }
    // required tells EF that this property is required so it will silent the null alert
    // null alerts happen to the reference types such as string 
    // casue premetive types as int the initial value is set to 0
    public required string UserName { get; set; }
    
}
