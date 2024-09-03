# SimpleImageDetector

SimpleImageDetector is an ASP.NET Core MVC web application designed to detect and label objects within images using Amazon Rekognition. This project provides a user-friendly interface for uploading images, which are then analyzed by AWS Rekognition, returning labels for the objects detected in the image. Additionally, the application leverages AWS Cognito for user registration and login management, ensuring secure access and personalized user experiences.

## Features

- **User Registration and Login Management:** Utilizes AWS Cognito for secure user registration, authentication, and management.
- **Image Upload:** Upload images directly from your browser for analysis.
- **AWS Rekognition Integration:** Leverages Amazon Rekognition's powerful image analysis capabilities.
- **Label Detection:** Automatically detects and labels objects within images.

## Prerequisites

Before you begin, ensure you have the following installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [AWS CLI](https://aws.amazon.com/cli/)
- AWS credentials configured on your machine (using `aws configure`)

## Installation

1. **Clone the repository:**

    ```bash
    git clone https://github.com/billysoomro/SimpleImageDetector.git
    cd SimpleImageDetector
    ```

2. **Restore dependencies and build the project:**

    ```bash
    dotnet restore
    dotnet build
    ```

3. **Run the application:**

    ```bash
    dotnet run
    ```

## Usage

1. Launch the application using the `dotnet run` command.
2. Open a browser and navigate to the application (typically at `http://localhost:5000`).
3. Register for a new account or log in using your existing credentials.
4. Upload an image to analyze its content using Amazon Rekognition.
5. The app will display labels detected by AWS Rekognition directly on the webpage.

## Important Notes

- **Temporary Image Handling:** Images are temporarily processed and displayed back via JavaScript. They are not stored, ensuring your data remains private and secure.
- **AWS Rekognition:** By default, AWS Rekognition processes images temporarily and does not store them. It only retains logs and metadata related to the analysis.
- **Security and Privacy:** User data is managed securely through AWS Cognito, protecting user information and ensuring compliance with data privacy standards.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
