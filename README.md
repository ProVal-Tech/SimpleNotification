<p align="center">
  <img src="./res/SimpleNotification.jpeg" alt="Simple Notification Icon" width="200">
  </p>

  # SimpleNotification

  A simple notification app.

  ## Description

  SimpleNotification is a lightweight application designed to show a simple notification prompt.

  ## Parameters

  | Parameter    | Alias | Required | Description                                    | Type   |
  | ------------ | ----- | -------- | ---------------------------------------------- | ------ |
  | `--message`  | `-m`  | true     | The message content of the notification        | String |
  | `--imageurl` | `-i`  | false    | Url to the image displayed in the notification | String |
  | `--email`    | `-e`  | false    | Email address to display in the notification   | String |
  | `--phone`    | `-p`  | false    | Phone number to display in the notification    | String |

  ## TOML Config File
  
  A TOML configuration file can be used instead of the other parameters.
  
  | Parameter      | Alias | Required | Description             | Type   |
  | -------------- | ----- | -------- | ----------------------- | ------ |
  | `--configfile` | `-c`  | true     | Path to the config file | String |
  
  The file should have the following format:

  ```toml
    message = "Hello, World!"
    image_url = "https://some.path.to/image.png"
    email = "support@company.local"
    phone = "000-000-0000"
  ```


  ## Usage

  ```shell
  SimpleNotification.exe --Message "Hello, World!" --ImageURL "https://raw.githubusercontent.com/ProVal-Tech/SimpleNotification/refs/heads/main/res/SimpleNotification.jpeg" --Email "myemail@somewhere.local" --Phone "000-000-0000"
  ```
