# CheckInstalledApp

A simple C# utility to check if an application is installed on a Windows system by querying the Windows Registry.

![Running Project](https://res.cloudinary.com/maheshdharhari/image/upload/v1726831037/Blog/CheckInstalledApp.png)

## Features

- Check for installed applications using their display names.
- Works with both 32-bit and 64-bit installations.
  
## Usage

1. **Add a Reference**: Include the `Microsoft.Win32` namespace in your project.
   
2. **Call the Method**: Use the `IsAppInstalled` method from the `InstalledApp` class to check if an application is installed.

```csharp
using CheckInstalledApp;

bool isInstalled = InstalledApp.IsAppInstalled("Your Application Name");

if (isInstalled)
{
    Console.WriteLine("The application is installed.");
}
else
{
    Console.WriteLine("The application is not installed.");
}
```

## Installation

You can clone the repository or download the source code to use in your own projects.

```bash
git clone https://github.com/cdcsit-maheshyadav/CheckInstalledApp.git
```

## Contribution

Contributions are welcome! Feel free to submit a pull request or report issues.

## License

This project is licensed under the MIT License. 

## Acknowledgements

- Inspired by the need for a simple method to check installed applications on Windows.

## Contact

For questions or feedback, please reach out to [contact@maheshyadav.com.np].