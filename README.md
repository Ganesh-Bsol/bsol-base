
# react-native-bsol-base

## Getting started

`$ npm install react-native-bsol-base --save`

### Mostly automatic installation

`$ react-native link react-native-bsol-base`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-bsol-base` and add `RNBsolBase.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNBsolBase.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNBsolBasePackage;` to the imports at the top of the file
  - Add `new RNBsolBasePackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-bsol-base'
  	project(':react-native-bsol-base').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-bsol-base/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-bsol-base')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNBsolBase.sln` in `node_modules/react-native-bsol-base/windows/RNBsolBase.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Bsol.Base.RNBsolBase;` to the usings at the top of the file
  - Add `new RNBsolBasePackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNBsolBase from 'react-native-bsol-base';

// TODO: What to do with the module?
RNBsolBase;
```
  