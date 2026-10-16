# NOTICE — 第三方素材与授权说明

本仓库的**代码、场景、UI、动画与工程配置**采用 [MIT License](LICENSE) 开源。

但以下内容**不在 MIT 授权范围内**，版权归各自权利人所有。二次使用前请自行确认并取得相应授权。

---

## 1. 第三方 3D 场景模型 —— 已排除出仓库

| 内容 | 来源 | 处理方式 |
| --- | --- | --- |
| 卧室 / 餐厅 / 菜品 3D 模型及配套贴图<br>（文件名含 `3d66Model-*`、`mat_3d66-VRayMtl-*`） | **3d66 网**（商业模型，VRay 材质） | ❌ **未纳入版本控制，不对外分发** |

**排除原因**

1. 单文件最大 147 MB（`卧室1.fbx`），超出 GitHub 100 MB 的单文件限制；
2. 属于第三方**商业**素材，公开分发可能超出其授权范围。

排除后仓库仅约 14 MB。clone 后在 Unity 中打开会看到模型缺失（Missing Prefab / 粉色材质），这是**预期行为**，不影响代码、UI、动画与工程配置的阅读。

**需要完整可玩版本**：请到 [Releases](https://github.com/xs2580/shiguang/releases) 下载 Windows 可执行包。

---

## 2. 保留在仓库中的第三方资源

| 内容 | 位置 | 版权 |
| --- | --- | --- |
| FreeUI / ZOSMA UI 素材包 | `Assets/Freeui/` | 归原资源包作者所有，遵循其原始授权 |
| TextMesh Pro（字体 / Shader / 示例） | `Assets/TextMesh Pro/` | © Unity Technologies，遵循 Unity 附带许可 |
| Unity Engine 运行时与模块 | 构建产物中 | © Unity Technologies |

---

## 3. 项目原创内容（MIT）

- 全部 C# 脚本：`Assets/FALES/InteractableObject.cs`、`Assets/beer.cs`、`Assets/control.cs`、`Assets/control1.cs`、`Assets/TuiChu.cs`
- 场景搭建、交互配置、Visual Scripting 逻辑图
- UI 面板 Prefab（`Canvas` 系列）、动画状态机（`.controller` / `.anim`）
- 工程配置：`ProjectSettings/`、`Packages/manifest.json`
- 剧情文本、游戏名称《拾光》、主视觉与结束页美术
- 项目文档（README 等）

---

## 4. 二次使用建议

- ✅ **学习、参考、二次开发代码**：欢迎，标注出处即可；
- ⚠️ **二次发布完整可玩版本**：请**自行取得 3D 场景素材的合法授权**；
- ❌ **整体商业售卖**：请勿直接使用，第三方素材授权不支持此类用途。

---

*如有版权疑问，请通过 Issue 联系。*
