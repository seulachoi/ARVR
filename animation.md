# animation 창
> animation window는 animation 클립을 제작/편집하는 등 각각의 animation을 관장하는 창 
- animation creator 에서 Door Double - left door - transform - rotation 클릭하여 추가하기 
- animation 생성은 녹화창을 누르고
- 커서를 끝점에 둔 다음 
- rotation 값을 변경해줌
# animator 창
> animation들의 동작을 이어주고 조건에 따른 동작들을 설정하는 창
> animation 이 작동할 수 있는 조건을 만들어줌 
- empty state를 생성해서 조건 단계를 끼워넣어줌
- animator - parameters에서 +버튼에서 bool 추가해줌; bool 이름은 isOpen
- inspector 창에서 conditions에서 isOpen이 true일때 실행되도록 조건을 추가
- animation DoorOpen 에서 마우스 우측 - make transition클릭하여 화살표로 방향 설정
- 화살표 클릭 하여 조건을 추가해줄 수 있음 
