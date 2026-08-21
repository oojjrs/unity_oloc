# OOJJRS' Localization

Unity UI에서 국가 코드를 국기 Sprite로 표시할 수 있도록 국기 PNG 16종, Sprite Atlas, `CountryFlagCollection`을 제공하는 패키지입니다.

## 설치

Unity Package Manager의 **Add package from git URL**에 입력합니다.

```text
https://github.com/oojjrs/unity_oloc.git?path=/Packages/src
```

대상은 Unity 6000.0 이상이며 패키지 ID는 `com.oojjrs.oloc`입니다.

## 구성 요소

| 구성 요소 | 종류 | 용도 |
| --- | --- | --- |
| `CountryFlagCollection` | ScriptableObject | 국가·로케일 코드로 국기 Sprite 조회 |
| `CountryFlagCollection.asset` | 기본 컬렉션 | 16개 국기 Sprite 참조 제공 |
| `Oloc.spriteatlasv2` | Sprite Atlas | 패키지 국기 Sprite 묶음 |
| `Runtime/Sprites` | PNG 16종 | 256×256 투명 캔버스의 국가별 국기 |

## 사용

기본 `CountryFlagCollection.asset`을 직렬화 필드로 참조한 뒤 `GetFlagSprite("ko-KR")`처럼 호출합니다. 마지막 국가 토큰을 대소문자 구분 없이 조회하며, 일치하는 Sprite가 없으면 `null`을 반환합니다.

국기는 언어와 동일하지 않으며, 국가상징을 상업적으로 사용할 때는 배포 지역의 규정을 별도로 확인해야 합니다.

## 문서

- [패키지 문서](Packages/src/Documentation~/index.md)
- [아트 제작](Packages/src/Documentation~/ART_SOURCE.md)
- [국가상징 사용 주의](Packages/src/Documentation~/NOTICE.md)
