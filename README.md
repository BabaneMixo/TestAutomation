Test Automation Project Readme
Overview

This project is a test automation framework designed to test APIs and the GUI of a web application. The project utilizes Docker to create a containerized environment containing both the API and the web store. Test automation is performed using Gauge as the testing framework, Selenium for GUI testing, and ChromeDriver as the WebDriver.
Prerequisites

Ensure the following dependencies are installed on your system:

    Docker
    Gauge
    ChromeDriver

Getting Started

    Clone the repository to your local machine:

    bash

git clone https://github.com/BabaneMixo/TestAutomation.git

Navigate to the project directory:

bash

cd your-repository

Start the Docker container containing the API and the store:

bash

docker-compose up -d

Install Gauge plugins and dependencies:

bash

gauge install

Run the tests:

bash

    gauge run specs

Project Structure

    docker-compose.yml: Configuration file for Docker Compose to set up the Docker containers.
    specs/: Directory containing the Gauge specifications for API and GUI testing.
    tests/: Directory containing the actual test implementations for both API and GUI tests.
    drivers/: Directory containing the ChromeDriver executable for Selenium.

Writing Tests
API Tests

API tests are written using Gauge with the help of a language-specific plugin, such as Gauge-Java, Gauge-Python, etc. The tests are defined in the specs/api directory, and the corresponding implementations can be found in the tests/api directory.
GUI Tests

GUI tests are written using Gauge with Selenium. The specifications for GUI tests are located in the specs/gui directory, and the test implementations are in the tests/gui directory.
Reporting

Gauge provides detailed reports after each test run. You can find the HTML reports in the reports directory.
Cleaning Up

After running the tests, stop and remove the Docker containers:

bash

docker-compose down

Troubleshooting

    If you encounter any issues, refer to the documentation of Gauge, Docker, and Selenium for troubleshooting tips.
    Ensure that the versions of Gauge, ChromeDriver, and Docker are compatible.



