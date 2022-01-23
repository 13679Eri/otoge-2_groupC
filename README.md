# otoge-2

## プレイ方法

このリポジトリを Clone するか, Code ボタン内の Download ZIP ボタンをクリックし ZIP ファイルをダウンロードし展開する. そうすると実行ファイルが, `/game/otoge-2/otoge-2.exe` にあるので開けばプレイすることができる

## Unity プロジェクトとして開く方法

### 1. Unity Hub でプロジェクトを作成する

テンプレートは 2D を選ぶと変更する項目が少く済むかもしれない

![UnityHubでの画面](https://user-images.githubusercontent.com/16481886/150673589-5814f360-11be-41a5-90df-ae6fbcb77266.png)

### 2. UnityPackage ファイルからインポートする

https://github.com/13679Eri/otoge-2_groupC/blob/main/otoge-2groupC.unitypackage
の `.unitypackage` ファイルをダウンロードし, 開いた UnityPackage の Project ウィンドウの Assets にドラッグ・アンド・ドロップする.
表示されたダイアログの 「import」ボタンを押してインポートする

![.unitypackageからインポートする画面](https://user-images.githubusercontent.com/16481886/150673854-a7453273-1e64-4846-98b9-d9489d55e46e.png)

シーンを読み込み直しますかというダイアログが表示された場合は「Reload」を押して読み込み直す
![シーンを読み込み直しますかというダイアログ](https://user-images.githubusercontent.com/16481886/150673926-636d5dd2-9f39-454e-bd80-3630da2e3922.png)

### 3. ゲーム画面のアスペクト比を設定する

Game ウィンドウの解像度の設定に 900×1600 を追加して良い感じに表示されるようにする.

![900×1600を追加している画面](https://user-images.githubusercontent.com/16481886/150674020-67e236ed-1bc1-4229-ab88-dd33b3438c86.png)

### 4. ビルド設定にシーンをすべてのシーンを追加する

Unity の 1 番上のメニューの File の Build Settings... をクリックし, Scenes in Build の欄に Project ウィンドウの Assets/Scenes フォルダ内に含まれるすべてのシーンをドラッグ・アンド・ドロップする

![Build Settings 画面](https://user-images.githubusercontent.com/16481886/150674169-f2105642-8ed4-42d7-b39a-6b129b58bc6d.png)

### 5. MIDI Animation Track for Unity Timeline を依存関係に追加する

UnityHub のプロジェクトから, プロジェクトが保存されているフォルダを開き,
![UnityHubの画面](https://user-images.githubusercontent.com/16481886/150674316-3a18c2ce-5cf7-48f2-873b-2882d6d72f3c.png)

プロジェクト名/Packages/manifest.json の中身を テキストエディタなどで

https://github.com/13679Eri/otoge-2_groupC/blob/main/Packages/manifest.json

の内容に変更して上書き保存する.
すると, サードパーティのサーバーからパッケージをインポートするという内容のダイアログが表示されるので閉じる.

![パッケージマネージャーのダイアログ](https://user-images.githubusercontent.com/16481886/150674624-e460266b-0bf7-4ba3-9086-527986a870e6.png)

以上の作業で Unity 上で開くことができるだろう. ゲームのエントリーポイントとなる Scene は, `Scenes/HomeScene` だ. タイトル画面から動作を確かめたいときには `Scenes/HomeScene` をダブルクリックで開こう.
