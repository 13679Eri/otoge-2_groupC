using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    //���ɗ�����
    //TODO:�����鑬�x���ǂƔ���ꏊ�Ƃ̋�������ݒ肷��K�v������B
    //�����ꏬ�ߕ��x�点�Ė炷 =>�@�m�[�c�͈ꏬ�ߕ��������������
    //����ꏊ�ɗ������ɉ�����΂悢 =>�@���x:����ꏊ�܂ł̋���/1���ߕ��̒���(s)

    double speed;
    float a;

    //�ꏬ�߂̎��Ԃ͂����炩�H:BPM����v�Z����(4*60/120)
    //MIDI�f�[�^����ƍ����BPM120 => 60�b�Ԃ�120�񉹂�����@=> 1�񓖂���0.5�b(60/120)
    //�ꏬ��:����4��� => 4*0.5 = 2�b => �ꏬ�߂̒�����2�b

    //����ꏊ�܂ł̋����͂����炩�H:Unity���̖��
    //70-(-50) => 120  (�m�[�c�̐����ꏊ(NoteGenerator��Y��)-�W���b�W�����g�G���A��Y��)

    private void Start()
    {
        speed = 62.5; // 120/2
        a = (float)speed;
    }


    void Update()
    {
        transform.Translate(0, -a * Time.deltaTime, 0);
    }

}
