# NOTICE — 第三方素材与授权说明

本仓库的**代码、场景、UI、动画与工程配置**采用 [MIT License](LICENSE) 开源。

但以下内容**不在 MIT 授权范围内**，版权归各自权利人所有。二次使用前请自行确认并取得相应授权。

---

## 1. 3D 模型 —— 建模由本项目团队完成（Blender），部分贴图源自第三方素材库

### 1.1 建模工作：团队原创

本作**全部 3D 模型**（卧室场景、餐厅场景、菜品道具）的**建模、UV 展开、材质分配、减面与整合**均由本项目团队在 **Blender** 中完成。

这一点可以由 FBX 文件自身的元数据佐证：

| 模型文件 | `HeaderExtension.Creator` | `ApplicationVendor` | 体积 |
| --- | --- | --- | --- |
| `卧室1.fbx` | `Blender (stable FBX IO) - 4.2.0 - 5.12.4` | Blender Foundation | 147.1 MB |
| `餐厅.fbx` | `Blender (stable FBX IO) - 3.6.12 - 5.4.1` | Blender Foundation | 45.6 MB |
| `菜1.fbx` | `Blender (stable FBX IO) - 3.6.12 - 5.4.1` | Blender Foundation | 16.2 MB |

建模工作流、Blender 导出参数、以及 Unity 侧对应的 `ModelImporter` 配置（记录在 `.fbx.meta` 中，**随仓库分发**）属于本项目原创内容，适用 MIT 许可。

### 1.2 贴图：部分源自第三方素材库

上述模型配套的**位图贴图**，有一部分沿用自 3d66 网素材库的原始资源（文件名仍保留下载时的编号前缀，如 `3d66Model-22310475-files-*`、`mat_3d66-VRayMtl-*`），这部分版权归原权利人所有，**不适用 MIT 许可**。

### 1.3 为何未纳入版本控制

| 内容 | 来源 | 处理方式 |
| --- | --- | --- |
| 3D 模型 FBX | 本项目团队（Blender 制作） | ❌ 未入库 —— 体积原因（单文件 147 MB 超 GitHub 100 MB 限制） |
| 配套贴图 | 部分源自 3d66 网素材库 | ❌ 未入库 —— 体积 + 第三方授权 |

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
- **全部 3D 模型的建模、UV、材质与整合工作**（Blender 3.6 / 4.2 制作并导出）
- **Blender → Unity 资产管线配置**（`.fbx.meta` 中的 `ModelImporter` 参数调优）
- 场景搭建、交互配置、Visual Scripting 逻辑图
- UI 面板 Prefab（`Canvas` 系列）、动画状态机（`.controller` / `.anim`）
- 工程配置：`ProjectSettings/`、`Packages/manifest.json`
- 剧情文本、游戏名称《拾光》、主视觉与结束页美术
- 项目文档（README 等）

---

## 4. 二次使用建议

- ✅ **学习、参考、二次开发代码**：欢迎，标注出处即可；
- ✅ **复用 Blender → Unity 建模管线**：欢迎，README 第 5.2 节有完整配置表；
- ⚠️ **二次发布完整可玩版本**：请**自行取得 3D 模型贴图的合法授权**（部分源自第三方素材库）；
- ❌ **整体商业售卖**：请勿直接使用。

---

*如有版权疑问，请通过 Issue 联系。*
