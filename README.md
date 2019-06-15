# BetterJoyForDolphin

Allows the Nintendo Switch Pro Controller and Joycons (original and 3rd party) to be used with [UDP version of Dolphin](https://mega.nz/#!Zx4TUQyZ!wc8-lbViJb4ZK1XXXrTVA6om_7Oc8s_6Ot4oX0-YYi0), the Nintendo Wii emulator.

This project is based on the amazing work done by Davidobot, creator of [BetterJoyForCemu](https://github.com/Davidobot/BetterJoyForCemu).

## Donations

If you would like to support the development of BetterJoyForDolphin, consider donating to the [BetterJoyForCemu](https://www.paypal.me/DavidKhachaturov/5) project.

And if you feel generous you can also donate directly to this project (and to me) at the following [link](https://www.paypal.me/yuk27/3).

## Getting Started

### Required software:
* [BetterJoyForDolphin (x64)](https://drive.google.com/open?id=1yAITJkbBUl7imseRzw4yvbrvXRrEGZP4)
* [UDP version of Dolphin](festyy.com/w1BnDk)

### Prerequisites

#### Configure Dolphin UDP

After downloading and extracting UDP Dolphin, you need to manually add the port information to WiimoteNew.ini (By default located on path ..\Documents\Dolphin Emulator\Config\WiimoteNew.ini):

### Extra code: 
```
UDP Wiimote/Port = 4434 
UDP Wiimote/Enable = 1
```

* (It's recommended to use port 4434,4435,4436,4437 for controller 1,2,3,4 respectively, but this can be modified to the user needs).

### Example:
```
[Wiimote1] 
Source = 0
UDP Wiimote/Port = 4434
UDP Wiimote/Enable = 1
[Wiimote2]
Source = 0
UDP Wiimote/Enable = 1
UDP Wiimote/Port = 4435
[Wiimote3]
Source = 0
UDP Wiimote/Enable = 1
UDP Wiimote/Port = 4436
[Wiimote4]
Source = 0
UDP Wiimote/Enable = 1
UDP Wiimote/Port = 4437
```

You can also download a already configured version of [WiimoteNew.ini](http://festyy.com/w1BQqN).

For more information on Dolphin UDP please refer to the [Dolphin Forum](https://forums.dolphin-emu.org/Thread-unofficial-udpmote-for-android).

### Installing

1. Install drivers (if BetterJoyForCemu has been run installed before this step is not needed)
    1. Run *! Driver Install (Run as Admin).bat*
2. Run BetterJoyForDolphin.exe
    1. If running for the first time, things might glitch out - just close the program normally and restart your computer for the drivers to take effect.
3. Connect your controllers (via bluetooth or USB).

3.1 (Optional: only if using Generic Joycons): Generic Joycons can be wronlgy detected as Pro Controllers as it's Serial can be different to the expected one in a third party Joycon. Once the Joycons have been detected by BetterJoyForDolphin as pro controllers, click on the Config option just under the controller icon. In there you can identify the type of controller, as also modify other parameters of the controller as the sensibility of the Accelerometer and the direction of the axis.

4. Start Dolphin UDP and ensure WiimoteNew has been correctly modified.
    1. If using Joycons, CemuHook will detect two controllers - each will give all buttons, but choosing one over the other just chooses preference for which hand to use for gyro controls.
5. Go to controllers option in Dolphin and configure it normally.

## Running the tests

Explain how to run the automated tests for this system

### Break down into end to end tests

Explain what these tests test and why

```
Give an example
```

### And coding style tests

Explain what these tests test and why

```
Give an example
```

## Deployment

Add additional notes about how to deploy this on a live system

## Built With

* [Dropwizard](http://www.dropwizard.io/1.0.2/docs/) - The web framework used
* [Maven](https://maven.apache.org/) - Dependency Management
* [ROME](https://rometools.github.io/rome/) - Used to generate RSS Feeds

## Contributing

Please read [CONTRIBUTING.md](https://gist.github.com/PurpleBooth/b24679402957c63ec426) for details on our code of conduct, and the process for submitting pull requests to us.

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/your/project/tags). 

## Authors

* **Billie Thompson** - *Initial work* - [PurpleBooth](https://github.com/PurpleBooth)

See also the list of [contributors](https://github.com/your/project/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* Hat tip to anyone whose code was used
* Inspiration
* etc
