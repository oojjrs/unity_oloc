# Unity Oloc

국가별 국기 PNG 16종과 Sprite Atlas, 직렬화된 `Sprite[]` 컬렉션을 제공하는 Unity 패키지입니다.

| 구성 요소 | 종류 | 용도 |
| --- | --- | --- |
| `Runtime/Sprites` | PNG 16종 | 256×256 투명 캔버스의 국가별 국기 |
| `Runtime/Atlas/Oloc.spriteatlasv2` | Sprite Atlas | 국기 PNG 묶음 |
| `Runtime/Prefab/CountryFlagCollection.asset` | ScriptableObject | 국기 Sprite 배열 보관 |
| `Runtime/Scripts/CountryFlagCollection.cs` | C# | 공개 `Sprite[] Sprites` API |

## 설치

Unity Package Manager에서 **Add package from git URL**을 선택하고 다음 URL을 입력합니다.

```text
https://github.com/oojjrs/unity_oloc.git?path=/Packages/src
```

## 사용

`Runtime/Prefab/CountryFlagCollection.asset`에는 16개 Sprite가 국가 코드 알파벳순으로 지정되어 있습니다. 이 에셋을 그대로 참조하거나, `Create > Oloc > Country Flag Collection`에서 별도 컬렉션을 만들어 원하는 순서로 지정합니다.

자세한 내용은 [패키지 문서](Packages/src/Documentation~/index.md)를 참고하세요.
