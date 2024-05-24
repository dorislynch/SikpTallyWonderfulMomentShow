
# react-native-sikp-tally-wonderful-moment-show

## Getting started

`$ npm install react-native-sikp-tally-wonderful-moment-show --save`

### Mostly automatic installation

`$ react-native link react-native-sikp-tally-wonderful-moment-show`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-sikp-tally-wonderful-moment-show` and add `RNSikpTallyWonderfulMomentShow.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNSikpTallyWonderfulMomentShow.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNSikpTallyWonderfulMomentShowPackage;` to the imports at the top of the file
  - Add `new RNSikpTallyWonderfulMomentShowPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-sikp-tally-wonderful-moment-show'
  	project(':react-native-sikp-tally-wonderful-moment-show').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-sikp-tally-wonderful-moment-show/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-sikp-tally-wonderful-moment-show')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNSikpTallyWonderfulMomentShow.sln` in `node_modules/react-native-sikp-tally-wonderful-moment-show/windows/RNSikpTallyWonderfulMomentShow.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Sikp.Tally.Wonderful.Moment.Show.RNSikpTallyWonderfulMomentShow;` to the usings at the top of the file
  - Add `new RNSikpTallyWonderfulMomentShowPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNSikpTallyWonderfulMomentShow from 'react-native-sikp-tally-wonderful-moment-show';

// TODO: What to do with the module?
RNSikpTallyWonderfulMomentShow;
```
  