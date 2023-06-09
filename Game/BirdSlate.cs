/**
 * @brief 게임 내의 새 슬레이트 UI 오브젝트입니다.
 */
class BirdSlate : SlideSlate
{
    /**
     * @brief 게임 내의 새 슬레이트 UI 오브젝트 속성에 대한 Getter/Setter입니다.
     */
    public float ChangeWingStateTime
    {
        set => changeWingStateTime_ = value;
    }


    /**
     * @brief 새 슬레이트 UI 오브젝트를 업데이트합니다.
     * 
     * @param deltaSeconds 초단위 델타 시간값입니다.
     */
    public override void Tick(float deltaSeconds)
    {
        if (bCanMove_)
        {
            UpdateWingState(deltaSeconds);
        }

        UpdateUITexture();

        base.Tick(deltaSeconds);
    }


    /**
     * @brief 날개 상태를 업데이트합니다.
     * 
     * @param deltaSeconds 초단위 델타 시간값입니다.
     */
    private void UpdateWingState(float deltaSeconds)
    {
        wingStateTime_ += deltaSeconds;

        if (wingStateTime_ > changeWingStateTime_)
        {
            wingStateTime_ = 0.0f;

            if (currWingState_ == Bird.EWing.NORMAL)
            {
                currWingState_ = Bird.GetCountWingState(prevWingState_);
                prevWingState_ = Bird.EWing.NORMAL;
            }
            else // currWingState_ == EWing.DOWN or currWingState_ == EWing.UP
            {
                prevWingState_ = currWingState_;
                currWingState_ = Bird.EWing.NORMAL;
            }
        }
    }


    /**
     * @brief 날개 상태에 맞는 텍스처를 업데이트합니다.
     */
    private void UpdateUITexture()
    {
        string birdTextureSignature = "BirdWingNormal";

        if (currWingState_ != Bird.EWing.NORMAL)
        {
            birdTextureSignature = (currWingState_ == Bird.EWing.UP) ? "BirdWingUp" : "BirdWingDown";
        }

        UITexture = birdTextureSignature;
    }


    /**
     * @brief 새 슬레이트 오브젝트가 움직일 수 있는지 확인합니다.
     */
    private bool bCanMove_ = true;


    /**
     * @brief 이전의 새 오브젝트의 날개 상태입니다.
     */
    private Bird.EWing prevWingState_ = Bird.EWing.NORMAL;


    /**
     * @brief 현재 새 오브젝트의 날개 상태입니다.
     */
    private Bird.EWing currWingState_ = Bird.EWing.UP;


    /**
     * @brief 새 오브젝트의 날개 상태가 지속된 시간입니다.
     */
    private float wingStateTime_ = 0.0f;


    /**
     * @brief 새 오브젝트의 날개 상태를 변경하는 시간입니다.
     */
    private float changeWingStateTime_ = 0.0f;
}