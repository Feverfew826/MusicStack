# MusicStack
음악(주로 배경 음악)을 쉽게 제어하기 위한 프로젝트입니다.\
음악을 재생순으로 리스트에 넣고, 리스트 상의 마지막 음악을 재생합니다.\
예: 
- A -> B -> C 순으로 음악을 재생하면, A와 B는 정지 시킨 후 C만 재생합니다.
  - 만약 C가 목록에서 제거되면, B가 리스트 상의 마지막이 되므로 B를 재생합니다.
  - 만약 B가 먼저 제거된 후 C가 제거된다면, A만 목록에 남았으므로 A를 재생합니다.

실제 게임에 사용하는 예를 들면,\
**로비 진입 -> 로비 배경음 재생 -> 창 열림 -> 창 배경음 재생 -> 창 닫힘 -> 로비 배경음 재생**\
과 같은 흐름을 상정하여 만들었습니다.

Package Manager에서 샘플 중 'UsageSample'을 임포트하여 쉬운 사용법을 확인할 수 있습니다.

## 설치 방법
### 1. 설치
'Package Manager'의 좌상단의 '+' 버튼을 누르고, 'Add package from git URL'을 누르고, 다음 주소를 입력하세요.\
`https://github.com/Feverfew826/MusicStack.git?path=Assets/Plugins/MusicStack`

## 사용된 라이센스
### 사용된 음원 라이센스(감사를 전합니다.)
Calm Piano Theme for Serene Moments by Gustavo_Alivera -- https://freesound.org/s/761374/ -- License: Attribution 4.0\
Emotional Piano and Violin by LolaMoore -- https://freesound.org/s/765211/ -- License: Attribution 4.0\
Peaceful Piano Melodies for Relaxing Moments by LolaMoore -- https://freesound.org/s/768285/ -- License: Attribution 4.0\
Tranquil Melodies by LolaMoore -- https://freesound.org/s/768736/ -- License: Attribution 4.0