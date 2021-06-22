
# Unity Move_Way

Unity Move_Way
-> Unity에서 Object의 4가지 이동 방식에 대한 설명이다.
>
```javascript
// 1. MoveTowards (등속 이동)
MoveTowards(현재 위치, 목표 위치, 속도);
```
>
```javascript
// 2. SmoothDamp (부드러운 감속 이동)
SmoothDamp(현재 위치, 목표 위치, 참조 속도, 속도);
```
>
```javascript
// 3. Lerp (선형 보간)
Lerp(현재 위치, 목표 위치, 속도);
```
>
```javascript
// 4. Slerp (구면 선형 보간)
Slerp(현재 위치, 목표 위치, 속도);
```
