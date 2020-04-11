import QtQuick 2.7
import QtQuick.Controls 2.0
import test 1.1

ApplicationWindow {
    visible: true
    width: 640
    height: 480
    title: qsTr("Hello World")

    Button {
      id: button
      text: "Test Button"
    }

    NetObject {
      id: test
      Component.onCompleted: function() {
          test.method()
      }
    }
}