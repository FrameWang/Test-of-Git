using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whither : MonoBehaviour {

    /// <summary> 是否已经拔剑 </summary>
    bool isDrawSword;

    /// <summary> 已经拔出的 </summary>
    Weapon currentWeapon;

    /// <summary> 装备中的武器 </summary>
    Weapon[] weapons;

    /// <summary> </summary>
    EnemyType currentType;

    /// <summary> </summary>
    Food food;

    /// <summary>
    /// 根据敌人类型拔剑
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public Weapon JudgeWeapon(EnemyType type)
    {
        return null;
    }

    /// <summary>
    /// 拔剑
    /// </summary>
    /// <param name="weapon"></param>
    public void DrawSword(Weapon weapon)
    {
        //动画

        //当前武器
        currentWeapon = weapon;
    }

    /// <summary>
    /// 收剑
    /// </summary>
    /// <param name="weapon"></param>
    public void CollectSword(Weapon weapon)
    {
        //动画

        //当前武器
        currentWeapon = null;
    }

    public void Attack()
    {
        /*
         * 播放攻击前置动画[]
         * 注册动画事件 根据配置文件 根据动作不同 播放不同的动画和注册不同的事
         * 播放动画+特效+释放飞行道具
         * * 在动画事件【前】中  是否中断（包括主动中断 被动中断）
         * * 在动画事件【中1】中 注册碰撞事件 用于开始击中检测 可以不检测碰撞直接算距离
         * * 在动画事件【中1】中 or 释放特效 并在特效上注册碰撞事件
         * * 在动画事件【中1】中 or 是否消耗自身属性
         * * 在动画事件【中1】中 or 改变物品数据
         * * 在动画事件【中1】中 or 改变装备数据
         * * 在动画事件【中1】中 or 是否进入某种持续状态
         * * * 在碰撞事件中 判断是否击中 判断是否中断
         * * * * 如果中断（包括主动中断 被动中断）动画提前结束 提前执行动画事件【后】
         * * * * 如果击中 被动方消耗属性 
         * * * * 如果击中 被动方进行强迫动作
         * * * * 如果击中 被动方是否进入某种持续状态
         * * * * 如果击中 被动方改变物品数据
         * * * * 如果击中 被动方改变装备数据
         * * * * 如果击中 主动方进行强迫动作
         * * * * 如果击中 主动方是否进入某种持续状态
         * * * * 如果击中 是否直接进入动画事件【中2】和动画事件【后】
         * * 在动画事件【中2】中 注销碰撞事件 
         * * 在动画事件【后】中 注销动画事件  是否中断（包括主动中断 被动中断）切换回哪一个动画
         * 播放攻击后置动画[]
         */
    }

    //HPDelta

    /// <summary>
    /// 吃
    /// </summary>
    public void Eat()
    {
        //背包交互

        //加血

    }

    /// <summary>
    /// 法印
    /// </summary>
    public void Sign()
    {
        // 播放动画

        // 释放道具（特效）

        // 注册动画事件※
        // 用于开始击中检测※

        // 注册碰撞事件※
        // 动画事件等判断是否击中※

        // 对手伤血
        //注销碰撞/动画/特效事件
    }

    /// <summary>
    /// 闪避
    /// </summary>
    public void Evade()
    {

    }
    
}

public class Food
{

}

public class MotionManager
{
    Motion[] motions;
}

public class Motion
{
    Animator anim;
}

public class Weapon
{

}

public enum WeaponType
{
    steel,//钢制
    silver//银制
}

public enum EnemyType
{
    mankind,//人类
    monster//怪物
}
