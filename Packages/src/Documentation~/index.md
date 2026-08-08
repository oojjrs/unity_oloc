# OOJJRS' Oloc

국가별 국기 PNG 16종과 Sprite Atlas를 제공하고, `CountryFlagCollection`에는 직렬화된 `Sprite[]`만 보관합니다.

| 경로 | 내용 |
| --- | --- |
| `Runtime/Sprites` | 투명 배경 256×256 RGBA PNG 16종 |
| `Runtime/Atlas/Oloc.spriteatlasv2` | 국기 PNG를 묶는 Sprite Atlas 에셋 |
| `Runtime/Prefab/CountryFlagCollection.asset` | 16개 국기 Sprite가 지정된 ScriptableObject 에셋 |
| `Runtime/Scripts/CountryFlagCollection.cs` | 국기 Sprite 배열을 보관하는 ScriptableObject |

모든 PNG는 같은 256×256 캔버스를 사용하지만 국기 필드는 미국 19:10, 브라질 10:7, 독일 5:3, 폴란드 8:5, 멕시코 7:4, 나머지 11개 3:2의 비율을 유지합니다.

`Runtime/Prefab/CountryFlagCollection.asset`의 `Sprites` 배열은 `BR, CN, DE, ES, FR, IT, JP, KR, MX, PL, RU, TH, TR, TW, UA, US` 순서입니다. Atlas에는 `Runtime/Sprites` 폴더가 이미 등록되어 있습니다.

기본 컬렉션을 그대로 참조하거나 `Create > Oloc > Country Flag Collection`에서 별도 에셋을 만들어 원하는 순서로 Sprite를 지정할 수 있습니다. 패키지에 포함된 Unity `.meta`는 GUID를 고정하므로 함께 유지해야 합니다.

## 1.0.1 변경 사항

- Unity Package Manager 표시 이름을 다른 OOJJRS 패키지와 같은 `OOJJRS' Oloc` 형식으로 통일했습니다.

제작 방식은 [아트 제작](ART_SOURCE.md), 국가상징 사용 주의는 [NOTICE](NOTICE.md)를 참고하세요.
