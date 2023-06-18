# FlappyBird2D *v1.0*
- 2D FlappyBird 게임 구현 프로젝트의 *v1.0*입니다.


## Platform

`FlappyBird2D` *v1.0*은 `Windows Platform`만 지원합니다.
<br><br>


## Requirements

`FlappyBird2D` *v0.0*를 유지 보수를 수행하기 위한 요구 사항은 다음과 같습니다.
- [git](https://git-scm.com/)
- [python 3.x](https://www.python.org/downloads/)
- [Visual Studio 2019 이상](https://visualstudio.microsoft.com/)
<br><br>


## Language

`FlappyBird2D` *v1.0*은 `C#` 으로 구현되었습니다.  
> `Windows`에 특화된 코드도 존재하므로, `Linux`나 `MacOSX`에서는 빌드되지 않습니다.

<br><br>


## Source

`FlappyBird2D` *v1.0*의 소스코드를 얻기 위해서는 `CMD`에 다음 명령어를 입력하면 됩니다.
```
git clone https://github.com/ChoiJiOne/FlappyBird2D --single-branch -b v1.0
```
<br><br>


## Structure

`FlappyBird2D` *v1.0*의 프로젝트 구조는 다음과 같습니다.
```
├─AudioModule
├─Bin
├─Content
│  ├─Audio
│  ├─DB
│  ├─Font
│  └─Texture
├─Crash
├─CrashPacket
├─CrashReportCollector
├─CrashReportSender
├─FontAltasTool
├─Game
├─Script
└─ThirdParty
    ├─Bin
    ├─miniaudio
    ├─SDL2
    └─stb
```
<br><br>


## Script

`FlappyBird2D` *v1.0*은 다양한 자동화 스크립트 기능을 지원합니다.  

| 스크립트 | 기능 |
|:---|:---|
| `GenerateProjectFiles.bat`    |  Visual Studio 솔루션 및 하위 프로젝트를 생성/업데이트하고 Visual Studio를 실행합니다. |
| `HotReload.bat`    | Visual Studio 솔루션 및 하위 프로젝트를 업데이트합니다. |
| `Build.bat`    | 빌드를 수행합니다. |

###  `GenerateProjectFiles.bat` 사용 방법

`GenerateProjectFiles.bat` 사용 방법은 `CMD`에 다음과 같은 명령어를 입력합니다.

> Visual Studio 2019를 사용할 경우...
```
> GenerateProjectFiles.bat vs2019
```

> Visual Studio 2022를 사용할 경우...
```
> GenerateProjectFiles.bat vs2022
```

### `HotReload.bat` 사용 방법

`HotReload.bat` 사용 방법은 `CMD`에 다음과 같은 명령어를 입력합니다.

> Visual Studio 2019를 사용할 경우...
```
> HotReload.bat vs2019
```

> Visual Studio 2022를 사용할 경우...
```
> HotReload.bat vs2022
```

### `Build.bat` 사용 방법

> `msbuild.exe` 경로를 반드시 환경 변수에 등록해야 합니다.

솔루션을 빌드하는 스크립트는 `Debug`, `Release`, `Shipping` 세 가지 파라미터를 받습니다.
파라미터를 전달하지 않으면, 스크립트는 실행되지 않습니다.

| 종류 | 설명 |
|:---:|:---|
| `Debug`    | 최적화를 수행하지 않고, 디버그 심볼(.pdb)을 생성합니다. |
| `Release`  | 최적화를 하지만 `Shipping`만큼은 하지 않고, 디버그 심볼(.pdb)을 생성하지 않습니다. |
| `Shipping` | 컴파일러가 수행할 수 있는 모든 최적화를 수행하고, 디버그 심볼(.pdb)을 생성하지 않습니다. |

빌드 스크립트를 실행하기 위해서는 `CMD`에서 다음과 같이 수행합니다.

> Visual Studio 2019를 사용할 경우...
```
> Build.bat vs2019 <option>
```

> Visual Studio 2022를 사용할 경우...
```
> Build.bat vs2022 <option>
```

> ex...
```
> Build.bat vs2019 Shipping
> Build.bat vs2022 Debug
```
<br><br>


## CrashReportCollector

`CrashReportCollector`는 크래시 발생 시 크래시 덤프 파일과 로그 파일을 수집하는 기능입니다.

> ※ CrashReportCollector은 현재 불안정기능입니다. 로컬에서는 잘 동작하니 로컬에서만 사용해주세요.
<br><br>


## Bug

플레이 혹은 개발 중 버그가 발생할 경우, [여기](https://github.com/ChoiJiOne/FlappyBird2D/issues) 에 제보해주시면 됩니다.
